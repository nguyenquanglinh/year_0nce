using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimDuongTrenForm
{
    public partial class Form1 : Form
    {
        DoThi dt;

        public Form1()
        {
            InitializeComponent();
            dt = new DoThi(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            dt.ThemDinh(e.Location.X, e.Location.Y);
        }

        private void docFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filetext = new DocFile_LuuFile(dt);
            filetext.Show();
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            var dfs = new DuyetDfs(dt);
            dfs.ToMau();

        }

        private void btnTimDuong_Click(object sender, EventArgs e)
        {
            var f2 = new DuyetDinh(dt);
            f2.Show();
        }

        private void btnThuTuDuyet_Click(object sender, EventArgs e)
        {
            var f2 = new TimDuong(dt);
            f2.Show();
        }






    }
}
