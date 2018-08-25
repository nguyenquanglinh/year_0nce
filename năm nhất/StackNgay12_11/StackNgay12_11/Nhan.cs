using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackNgay12_11
{
    public partial class Nhan : Form
    {
        public Nhan()
        {
            InitializeComponent();
        }
        TextBox[,] arr;
       
        private void button1_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtHang.Text);
            int n = int.Parse(txtCot.Text);
            TaoGroup(m, n);
        }
        void TaoGroup(int m, int n)
        {
            arr = new TextBox[m, n];
             
            int ox = 0, oy = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = new TextBox()
                    {
                        Text="0",
                    Height=20,
                    Width=20,
                    Location=new Point(ox,oy+15),
                    };
                groupBoxTao.Controls.Add(arr[i,j]);
                oy += 20;
                ox = 0;
                }
                ox += 20;
            }
           
        }

        int Tong()
        {
            int x = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    x += int.Parse(arr[i, j].Text);
                }
            }
            return x;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            txtTong.Text = Tong().ToString();
        }
    }
}
