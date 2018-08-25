using ChatLib;
using ChatLib.MessageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{

    class ClientMessageProcessor : MessageProcessorBase
    {

        public List<MessageBase> Response { get; set; }

        public ClientMessageProcessor()
        {
            Response = new List<MessageBase>();
        }

        public override void Process(ChatLib.MessageModel.ConnectMessageSuccess message)
        {
            System.Windows.Forms.MessageBox.Show("Kết nối server thành công ");
        }

        public override void Process(ChatLib.MessageModel.ConnectMessageFailed message)
        {
            System.Windows.Forms.MessageBox.Show("Kết nối server, Lỗi:" + message.Reason);
        }

     
    }
}
