using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackNgay12_11
{
    public partial class Stack : UserControl
    {
        public Stack()
        {
            InitializeComponent();
            btnKq.Enabled = false;
            comboBox1.Enabled = false;
        }
        TextBox[,] arr1;
        TextBox[,] arr2;
        TextBox[,] arr;
        private void btnTao_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("chọn cách tính");
            btnKq.Enabled = true;
            comboBox1.Enabled = true;
        }

        void Tao()
        {
            var m = int.Parse(txtHang.Text);
            var n = int.Parse(txtCot.Text);
            grorp1.Controls.Clear();
            arr1 = TaoGroup(grorp1, m, n);
            group2.Controls.Clear();

            arr2 = TaoGroup(group2, m, n);
        }

        TextBox[,] TaoGroup(GroupBox x, int m, int n)
        {
            arr = new TextBox[m, n];
            int Ox = 0, Oy = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = new TextBox()
                  {
                      Text = "0",
                      Width = 20,
                      Height = 20,
                      Location = new Point(Ox, Oy + 15),
                  };
                    x.Controls.Add(arr[i, j]);
                    Ox += 20;
                }
                Ox = 0;
                Oy += 20;
            }
            return arr;
        }

        int[,] MangInt(TextBox[,] x)
        {
            var a = new int[x.GetLength(0), x.GetLength(1)];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(x[i, j].Text);
                }
            }
            return a;
        }

        private void btnKt_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            if (comboBox1.SelectedItem == "+")
            {
                Tao();
                Cong();
            }
            else if (comboBox1.SelectedItem == "-")
            {
                Tao();
                Tru();
            }
            else if (comboBox1.SelectedItem == "X")
            {
                Nhan();
            }
            else
            {
                MessageBox.Show("chọn cách tính");
            }

        }

        void Nhan()
        {
            txtCotM1.ReadOnly = false;
            txtCotM2.ReadOnly = false;
            txtHangM2.ReadOnly = false;
            txtHangM1.ReadOnly = false;
            txtCot.ReadOnly = true;
            txtHang.ReadOnly = true;

            arr1 = TaoGroup(grorp1, int.Parse(txtHangM1.Text = "0"), int.Parse(txtCotM1.Text = "0"));
            arr2 = TaoGroup(group2, int.Parse(txtHangM2.Text), int.Parse(txtCotM2.Text));

            var ar1 = MangInt(arr1);
            var ar2 = MangInt(arr2);

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    for (int k = 0; k < arr1.GetLength(0); k++)
                    {
                        arr[i, j].Text = (int.Parse(ar1[i, k].ToString()) + int.Parse(ar2[k, j].ToString())).ToString();

                    }
                }
            }
        }

        void Cong()
        {
            var ar1 = MangInt(arr1);
            var ar2 = MangInt(arr2);
            group3.Controls.Clear();
            TaoGroup(group3, int.Parse(txtHang.Text), int.Parse(txtCot.Text));

            for (int i = 0; i < ar1.GetLength(0); i++)
            {
                for (int j = 0; j < ar1.GetLength(1); j++)
                {
                    var x = (int.Parse(ar1[i, j].ToString()) + int.Parse(ar2[i, j].ToString())).ToString();
                    arr[i, j].Text = x;
                }
            }
        }

        void Tru()
        {
            var ar1 = MangInt(arr1);
            var ar2 = MangInt(arr2);
            group3.Controls.Clear();
            TaoGroup(group3, int.Parse(txtHang.Text), int.Parse(txtCot.Text));

            for (int i = 0; i < ar1.GetLength(0); i++)
            {
                for (int j = 0; j < ar1.GetLength(1); j++)
                {
                    var x = (int.Parse(ar1[i, j].ToString()) - int.Parse(ar2[i, j].ToString())).ToString();
                    arr[i, j].Text = x;
                }
            }
        }

        private void txtHangM2_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;

            try
            {
                if (txt.Text == txtCotM1.Text)
                {
                    error.SetError(txt, "nhập lại số cột của mảng 2");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
