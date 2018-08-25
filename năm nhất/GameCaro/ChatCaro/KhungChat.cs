using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chatlib;
using Chatlib.MessageModel;
using Chatlib.MessagerModel;
using System.IO;
namespace ChatCaro
{
    public partial class KhungChat : UserControl
    {
        public KhungChat()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            client = new ClientChat(2302);
            client.Processor.Add(new SendProcess(this));
        }
        ClientChat client;

        private void ThemCauChat(string cauChat)
        {
            this.richTextBox1.AppendText(cauChat + "\n");
            txtMessage.Clear();
        }

        string nameUserRecive;
        private void btnSend_Click(object sender, EventArgs e)
        {
            nameUserRecive = (string)comboBox1.SelectedItem;
            if (nameUserRecive == null)
                ThemCauChat("chưa chọn người kết nối");
            client.Send(new SendMessage(txtUserName.Text, nameUserRecive, txtMessage.Text));
            ThemCauChat(txtMessage.Text);
        }
        #region
        class SendProcess : MessagerProcessorBase
        {
            KhungChat form;
            //1 hàm tạo
            public SendProcess(KhungChat form)
            {
                this.form = form;
            }
            //2 tên máy khách
            public override void Process(ConnectMessageSuccess message)
            {
                this.form.Text = message.NameSender;
            }
            //3 gửi tin nhắn thất bại
            public override void Process(ConnecMessageFaile message)
            {
            }
            //5 nhận được file
            public override void Process(RecievedFile message)
            {
                File.WriteAllBytes("d:/chat/" + message.FileName, message.ByteData);

            }
            //4 nhận được tin nhắn
            public override void Process(RecievedMessage message)
            {
            }
        }
        #endregion


    }

}
