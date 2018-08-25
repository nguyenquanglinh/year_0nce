using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoThiTrenForm
{
    public partial class Form1 : Form
    {
        IDoThi doThi;
        CacFile doFile = new FileText();
        GrapDrawler drawler;
        IThuatToan thuatToan;
        public Form1()
        {
            InitializeComponent();
            doThi = new DoThi();
            drawler = new GrapDrawler(panel);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("không được chọn vào đây");
        }

        private bool OverLap(Diem diem)
        {
            foreach (var dinh in doThi.TapDinh)
                if (dinh.Overlap(diem))
                    return true;
            return false;
        }

        private void VeDoThi()
        {
            this.panel.Controls.Clear();
            drawler.Draw(this.doThi);
            this.panel.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.pos)|*.pos";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.panel.Controls.Clear();
                var fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                doThi = doFile.DocFile(fileName);
                doThi.OnGraphChanged -= doThi_OnGraphChanged;
                doThi.OnGraphChanged += doThi_OnGraphChanged;
                VeDoThi();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (drawler != null && doThi != null)
                drawler.UpdateEdge(doThi);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                doFile.LuuFile(fileName, doThi);
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            var diem = new Diem() { Location = new Point(e.Location.X, e.Location.Y), Color = Color.Blue, };
            if (!OverLap(diem))
            {
                doThi.ThemDinh(diem);
                this.panel.Controls.Add(diem);
                doThi.OnGraphChanged -= doThi_OnGraphChanged;
                doThi.OnGraphChanged += doThi_OnGraphChanged;
            }
        }

        void doThi_OnGraphChanged(object sender, EventArgs e)
        {
            VeDoThi();
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            //chưa làm gì
        }

        private void btnTimDuong_Click(object sender, EventArgs e)
        {
            if (!KiemTraDieuKien())
                return;
            var fw = new TimDuong(doThi, thuatToan, panel);
            fw.Show();
        }

        private bool KiemTraDieuKien()
        {
            if (thuatToan == null)
            {
                MessageBox.Show("chưa chọn thuật toán");
                return false;
            }
            if (doThi.SoDinhCuaDoThi <= 1)
            {
                MessageBox.Show("đồ thị thị phải có ít nhất 2 đỉnh");
                return false;
            }
            return true;
        }

        private void cbbThuatToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThuatToan.SelectedItem.ToString() == "bfs")
                thuatToan = new DuyetBfs(doThi);
            if (cbbThuatToan.SelectedItem.ToString() == "dfs")
                thuatToan = new DuyetDfs(doThi);
        }

        private void btnThuTuDuyet_Click(object sender, EventArgs e)
        {
            if (!KiemTraDieuKien())
                return;
            var f2 = new ThuTuDuyet(doThi, panel);
            f2.Show();
        }



    }
}
