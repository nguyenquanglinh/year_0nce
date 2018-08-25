using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackWindow5_11_2017
{
    public partial class Abc : Form
    {


        TextBox[,] arr, arr1, arr2;

        public Abc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            grbMang1.Controls.Clear();
            arr = null;
            arr1 = TaoMangNullGepVaoGroup(grbMang1, arr);
            grbMang2.Controls.Clear();
            arr2 = TaoMangNullGepVaoGroup(grbMang2, arr);
            arr = null;
        }

        TextBox[,] TaoMangNullGepVaoGroup(GroupBox group, TextBox[,] a)
        {
            var m = int.Parse(txtHang.Text);
            var n = int.Parse(txtCot.Text);
            int Ox = 0;
            int Oy = 0;
            a = new TextBox[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = new TextBox()
                {
                    Text = "0",
                };
                    a[i, j].Width = 20;
                    a[i, j].Height = 20;
                    a[i, j].Location = new Point(Ox, Oy + 15);

                    Ox += 20;
                    group.Controls.Add(a[i, j]);
                }
                Ox = 0;
                Oy += 20;
            }
            return a;
        }

        void GepMangCoGiaTriGepVaoGroup(GroupBox group, TextBox[,] a)
        {
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            int Ox = 0, Oy = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j].Width = 20;
                    a[i, j].Height = 20;
                    a[i, j].Location = new Point(Ox, Oy + 15);

                    Ox += 20;
                    group.Controls.Add(a[i, j]);
                }
                Ox = 0;
                Oy += 20;
            }
        }

        UserControl1 s;

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            grbKetQua.Controls.Clear();
            arr = new TextBox[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr[i, j] = new TextBox()
                    {
                        Text = (int.Parse(arr1[i, j].Text) + int.Parse(arr2[i, j].Text)).ToString(),
                    };
                }
            }

            GepMangCoGiaTriGepVaoGroup(grbKetQua, arr);

        }

        //private void txtHang_Validating(object sender, CancelEventArgs e)
        //{
        //    var txt = sender as TextBox;
        //    var x = int.Parse(txt.Text);
        //    try
        //    {
        //        if (x < 0 || x > 1000)
        //            error.SetError(txt, "nhập lại số hàng số cột bằng số");
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        private void btnTest_Click(object sender, EventArgs e)
        {
              s = new UserControl1()
            {
                Location = new Point(0, 0),
            };
            grbMang1.Controls.Add(s);

            
            
        }

        private void KtTest_Click(object sender, EventArgs e)
        {
          //  s.GhepMangNullVaoGrup();
            var x=new TextBox[3,4];
           
        }

        private void Abc_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

    }
}

