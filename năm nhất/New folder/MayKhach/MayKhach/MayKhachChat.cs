using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayKhach
{
    public partial class MayKhachChat : UserControl
    {
        public MayKhachChat()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Client client;

        private void client_ThemCauChat(object sender, EventArgs e)
        {
            var cauChat = sender as string;
            if (cauChat == null)
                throw new Exception("lỗi rồi");
            this.KhungChat.Items.Add(cauChat);
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            if (client == null)
            {
                MessageBox.Show("chưa kết nối tới sever");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtCauChat.Text))
            {

            }
            else if (txtNguoiNhan.Text == "tất cả mọi người" || string.IsNullOrWhiteSpace(txtNguoiNhan.Text))
                client.GuiTinDi("[@/*" + "@]" + txtCauChat.Text);
            else
                client.GuiTinDi("[@" + txtNguoiNhan.Text + "@]" + txtCauChat.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Nhập tên người dùng");
                return;
            }
            client = new Client(txtTenDangNhap.Text);
            client.ThemCauChat -= client_ThemCauChat;
            client.ThemCauChat += client_ThemCauChat;
        }


    }
}
