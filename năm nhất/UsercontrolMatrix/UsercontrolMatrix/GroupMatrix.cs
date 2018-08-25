using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsercontrolMatrix
{
    public partial class GroupMatrix : UserControl
    {
        public GroupMatrix()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Đặt và lấy giá trị của ma trận
        /// </summary>
        public int[,] Value
        {
            get
            {
                return LayKetQuaTRenGroup();
            }
            set
            {
                GanGiaTri(value);
            }
        }

        private void groupBoxMatrix_Enter(object sender, EventArgs e)
        {
        }
     
        TextBox[,] arr;
        string ten;

        [Browsable(true)]
        public string Ten
        {
            get
            {
                return ten;

            }
            set
            {
                ten = value;
                groupBoxMatrix.Text = ten;
            }
        }


        void TaoGroup(int m, int n)
        {
            groupBoxMatrix.Controls.Clear();
            arr = new TextBox[m, n];
            int ox = 0, oy = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = new TextBox()
                    {
                        Text = "0",
                        Width = 20,
                        Height = 20,
                        Location = new Point(ox, oy + 15),
                    };
                    ox += 20;

                    groupBoxMatrix.Controls.Add(arr[i, j]);
                }
                oy += 20;
                ox = 0;
            }
        }

        int[,] LayKetQuaTRenGroup()
        {
            var ar = new int[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    ar[i, j] = int.Parse(arr[i, j].Text);
                }
            }
            return ar;
        }

        void GanGiaTri(int[,] a)
        {
            this.TaoGroup(a.GetLength(0), a.GetLength(1));
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    arr[i, j].Text = a[i, j].ToString();
                }
            }
        }

    }
}
