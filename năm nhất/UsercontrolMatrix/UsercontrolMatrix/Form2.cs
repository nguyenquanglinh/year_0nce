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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            groupMatrix1.Ten = "abc";
            groupMatrix1.Value = new int[int.Parse(txthang.Text), int.Parse(txtcot.Text)];
        }

        private void btnTong_Click_1(object sender, EventArgs e)
        {
            var arr = groupMatrix1.Value;
            int tông = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    tông += arr[i, j];
                }
            }
            txtTong.Text = tông.ToString();
        }
    }
}
