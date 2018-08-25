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
    public partial class TimDuong : Form
    {
        private DoThi dt;

        public TimDuong()
        {
            InitializeComponent();
        }

        public TimDuong(DoThi dt):this()
        {
            // TODO: Complete member initialization
            this.dt = dt;
            LayTenHinhTron();
        }
        void LayTenHinhTron()
        {
           
                cbbBd.Items.Clear();
                cbbKt.Items.Clear();
            foreach (var item in dt.tapDinh)
            {
                cbbBd.Items.Add(item.NameHt);
                cbbKt.Items.Add(item.NameHt);
            }
        }
        int bd = 0, kt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            var dfs = new DuyetDfs(dt);
            if (bd == kt)
            {
                MessageBox.Show("chọn lại điểm bắt đầu và kết thúc");
                return;
            }
            dfs.TimDuongMin(bd, kt);
        }

        private void cbbBd_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd = int.Parse(cbbBd.SelectedItem.ToString());
        }

        private void cbbKt_SelectedIndexChanged(object sender, EventArgs e)
        {
            kt = int.Parse(cbbKt.SelectedItem.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
