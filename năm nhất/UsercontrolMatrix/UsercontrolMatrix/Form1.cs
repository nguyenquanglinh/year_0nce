using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsercontrolMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = int.Parse(txtHang.Text);
            var n = int.Parse(txtCot.Text);
            groupMatrix1.Enabled = true;
            groupMatrix2.Enabled = true;
            groupMatrix1.(new int[m,n]);
            groupMatrix2.GanGiaTri(new int[m, n]);
            comboBox1.Enabled = true;
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            var arr1 = groupMatrix1.LayKetQuaTRenGroup();
            var arr2 = groupMatrix2.LayKetQuaTRenGroup();

            var arrKq = new int[arr1.GetLength(0), arr2.GetLength(1)];
            if (comboBox1.SelectedItem == "+")
            {
                arrKq = Cong(arr1, arr2);
            }
            else if (comboBox1.SelectedItem == "-")
            {
                arrKq = Tru(arr1, arr2);
            }
            else if (comboBox1.SelectedItem == "/")
            {
                arrKq = Chia(arr1, arr2);
            }
            else if (comboBox1.SelectedItem == "*")
            {
                var m = int.Parse(txtHang.Text);
                var n = int.Parse(txtCot.Text);
                if (m == n)
                {

                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            int tong = 0;
                            for (int k = 0; k < m; k++)
                            {
                                tong = tong + arr1[i, k] * arr2[k, j];
                            }
                            arrKq[i, j] = tong;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhap lai so cot cua ma tran");
                }
            }
            groupMatrix3.GanGiaTri(arrKq);
            groupMatrix3.Enabled = true; 
        }

        private int[,] Chia(int[,] a, int[,] b)
        {
            var x = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (b[i, j] != 0)
                        x[i, j] = a[i, j] / b[i, j];
                    else
                    {
                        MessageBox.Show("nhập lại các giá trị của mảng b khác 0");
                        return x;
                    }
                }
            }
            return x;
        }

        private int[,] Cong(int[,] a, int[,] b)
        {
            var x = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    x[i, j] = a[i, j] + b[i, j];
                }
            }
            return x;
        }

        private int[,] Tru(int[,] a, int[,] b)
        {
            var x = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    x[i, j] = a[i, j] - b[i, j];
                }
            }
            return x;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnKetQua.Enabled = true;
        }



    }
}
