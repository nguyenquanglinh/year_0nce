using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhDinhThuc
{
    public partial class MaTrix : UserControl
    {
        public MaTrix()
        {
            InitializeComponent();
        }
        public double[,] Value
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
        public void TaoGroup(int m, int n)
        {
            grbMatrix.Controls.Clear();
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

                    grbMatrix.Controls.Add(arr[i, j]);
                }
                oy += 20;
                ox = 0;
            }
        }

        double[,] LayKetQuaTRenGroup()
        {
            var ar = new double[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    ar[i, j] = int.Parse(arr[i, j].Text);
                }
            }
            return ar;
        }

        public void GanGiaTri(double[,] a)
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
