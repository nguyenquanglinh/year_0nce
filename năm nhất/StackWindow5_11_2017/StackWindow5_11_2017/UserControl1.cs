using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackWindow5_11_2017
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            GrupNhap.Text = "TextBox arr[,]";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        TextBox[,] arr;

        public void TaoGrup(GroupBox grup)
        {
            var m = int.Parse(txtHang.Text);
            var n = int.Parse(txtCot.Text);
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
                    Ox += 20;
                    grup.Controls.Add(arr[i, j]);
                }
                Ox = 0;
                Oy += 20;
            }
        }

        public int[,] LayaKetQuaTuGrup()
        {

        }

        public int[,] ChenMang()
        {
            var m = int.Parse(txtHang.Text);
            var n = int.Parse(txtCot.Text);
            var ar = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ar[i, j] = int.Parse(arr[i, j].Text);
                }
            }
            return ar;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            grup1.Controls.Clear();
            TaoGrup(grup1); 
        }
    }
}


