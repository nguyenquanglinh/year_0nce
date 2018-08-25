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
    public partial class TimDuong : Form
    {
        DoThi dt { get; set; }
        public TimDuong()
        {
            InitializeComponent();
        }

        int bd, kt;
        List<string> tenDinh;
        public TimDuong(DoThi doThi)
            : this()
        {
            dt = doThi;
            New();
        }

        private void New()
        {

            tenDinh = dt.tenDinh();
            if (tenDinh.Count <= 1)
            {
                MessageBox.Show("nhập lại đồ thị");
                this.Enabled = false;
                return;
            }
            NhapDinhLenCBB(cbbBD);
            NhapDinhLenCBB(cbbKT);
        }


        void NhapDinhLenCBB(ComboBox cbb)
        {
            cbb.Items.Clear();
            foreach (var item in tenDinh)
                cbb.Items.Add(item);
        }

        private void cbbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd = int.Parse(cbbBD.SelectedItem.ToString());
            int x = cbbBD.SelectedIndex;
            tenDinh.RemoveAt(x);
            NhapDinhLenCBB(cbbKT);
        }

        private void cbbKT_SelectedIndexChanged(object sender, EventArgs e)
        {
            kt = int.Parse(cbbKT.SelectedItem.ToString());
            int x = cbbKT.SelectedIndex;
            tenDinh.RemoveAt(x);
            NhapDinhLenCBB(cbbBD);
        }
        void KetThuc()
        {
            if (MessageBox.Show("bạn có muốn thoát không", "thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                this.Close();
            else
                New();
        }

        private void btnTimDuong_Click(object sender, EventArgs e)
        {
            var xx = dt.TimDuong(bd, kt);
          
            if (xx.tapDinh.Count == 0)
                MessageBox.Show("không có đường đi");
         else  
                MessageBox.Show("có đường đi  từ "+bd.ToString()+"đến"+kt.ToString());
            KetThuc();
        }

        private void btnDuongMin_Click(object sender, EventArgs e)
        {
            dt.TimDuongMin(bd, kt);
            KetThuc();

        }
    }
}
