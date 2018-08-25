using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnhCanBan
{
    public partial class Multiply : Form
    {
        public Multiply()
        {
            InitializeComponent();
        }
        public int[,] Arr;
        private void cbbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLuaChon.SelectedIndex == 1)
            {
                Arr = new int[3, 3] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
            }
            else if (cbbLuaChon.SelectedIndex == 2)
            {
                Arr = new int[3, 3] { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
            }
            else if (cbbLuaChon.SelectedIndex == 3)
            {
                Arr = new int[4, 4] { { 0, 8, 2, 10 }, { 4, 12, 6, 14 }, { 3, 11, 1, 9 }, { 7, 15, 5, 13 } };
            }

        }

        public Bitmap bitmap { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
