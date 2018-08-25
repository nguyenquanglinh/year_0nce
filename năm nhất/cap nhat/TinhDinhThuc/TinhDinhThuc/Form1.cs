using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhDinhThuc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            maTrix1.TaoGroup(int.Parse(txtHang.Text), int.Parse(txtCot.Text));
            btnTinh.Enabled = true;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            var ar = maTrix1.Value;
            if (cbxLuachon.SelectedItem == "Tính định thức")
                txtKq.Text = (DinhThuc(maTrix1.Value).ToString());
            else if (cbxLuachon.SelectedItem == "Biến đổi sơ cấp hàng")
            {
                BienDoiSoCapHang(ar);
                maTrix1.GanGiaTri(ar);
            }
            else if (cbxLuachon.SelectedItem == "Rank")
                return;


        }

        static int Rank(double[,] arr)
        {
            BienDoiSoCapHang(arr);
            int dem =0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (KtHangBang0(LayCacGiaTriHangThuN(arr, i)))
                    continue;
                dem++;
            }
            return dem;
        }
        static bool KtHangBang0(double[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] != 0)
                    return false;
            }
            return true;
        }

        static double[] LayCacGiaTriHangThuN(double[,] arr, int n)
        {
            var ar = new double[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                ar[i] = arr[n, i];
            }
            return ar;
        }

        static int KtViTriHangKhac0Min(double[,] ar)
        {
            var min = ar[1, 0];
            int x = 0;
            for (int i = 2; i < ar.GetLength(0); i++)
            {
                if (ar[i, 0] < min && ar[i, 0] != 0)
                    x = i;
            }
            return x;
        }

        static void DoiViTri2HangBang0TrongMatrix(double[,] arr, int viTri)
        {
            var min = KtViTriHangKhac0Min(arr);
            var aN = LayCacGiaTriHangThuN(arr, min);
            var a0 = LayCacGiaTriHangThuN(arr, 0);
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                arr[0, i] = aN[i];
                arr[min, i] = a0[i];
            }
        }

        static void BienDoiSoCapHang(double[,] arr)
        {
            if (arr.GetLength(0) != arr.GetLength(1))
            {
                MessageBox.Show("chỉ tính được định thức của ma trận vuông");
                return;
            }
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                if (arr[0, 0] == 0)
                    DoiViTri2HangBang0TrongMatrix(arr, 0);
                var arTren = LayCacGiaTriHangThuN(arr, i);
                for (int j = i + 1; j < arr.GetLength(0); j++)
                {
                    var arDuoi = LayCacGiaTriHangThuN(arr, j);
                    double thuong = arDuoi[i] * 1.0 / arTren[i];
                    for (int k = i; k < arr.GetLength(1); k++)
                    {
                        arr[j, k] = (-arTren[k] * thuong + arDuoi[k]);
                    }
                }

            }
        }

        static double DinhThuc(double[,] arr)
        {
            BienDoiSoCapHang(arr);
            double kq = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        kq = kq * 1.0 * arr[i, j];
                        break;
                    }
                }
            }
            return kq;
        }
    }
}
