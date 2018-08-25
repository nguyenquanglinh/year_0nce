using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeDoThiLienThong
{
    public partial class DoThiLienThongAbc : Form
    {
        DoThi dt;
        int x;
        int y;

        public DoThiLienThongAbc()
        {
            InitializeComponent();
            dt = new DoThi(this);
        }

        private void DoThiLienThong_MouseUp(object sender, MouseEventArgs e)
        {
            dt.ThemDinh(e.Location.X, e.Location.Y);
            btnTimDuong.Enabled = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dt.LuuFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new Form2(dt);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.ToMau();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dt.DocFile();
            MessageBox.Show("hoàn thành");
            btnTimDuong.Enabled = true;
        }

        private void btnTimDuong_Click(object sender, EventArgs e)
        {
            var f3 = new TimDuong(dt);
            f3.Show();
            this.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }
    }
}

