using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoThiTrenForm
{
    public partial class TimDuong : Form
    {
        public TimDuong()
        {
            InitializeComponent();
        }
        IDoThi doThi;
        public TimDuong(IDoThi doThi, IThuatToan thuatToan, Panel pannel)
            : this()
        {

            this.doThi = doThi;
            this.thuatToan = thuatToan;
            this.panel = pannel;
            ThemLuaChon();
        }

        private void ThemLuaChon()
        {
            foreach (var item in doThi.TapDinh)
            {
                cbbBatDau.Items.Add(item.PointName);
                cbbKetThuc.Items.Add(item.PointName);
            }
        }
        int bd = 0;
        int kt = 0;
        private void cbbBatDau_SelectedValueChanged(object sender, EventArgs e)
        {
            bd = int.Parse(cbbBatDau.SelectedItem.ToString());
        }

        private void cbbKetThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            kt = int.Parse(cbbKetThuc.SelectedItem.ToString());
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (bd == kt)
            {
                MessageBox.Show("điểm bắt đầu phải khác điểm kết thúc");
                return;
            }
            else
            {
                var ss = thuatToan.TimDuongMin(bd, kt);
                if (ss == null)
                {
                    MessageBox.Show("không có đường đi ");
                    return;
                }
                var draw = new GrapDrawler(panel);
                draw.DrawHinh(ss);
                MessageBox.Show("đã tô màu phần đường đi");
                this.Close();
            }
        }



        IThuatToan thuatToan;

        Panel panel;
    }
}
