using ChatLib;
using ChatLib.MessageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServerMessageProcessor : MessageProcessorBase
    {
        private ClientManager clientManager;

        private MayKhach client;

        public List<MessageBase> Response { get; set; }

        public ServerMessageProcessor(ClientManager manager, MayKhach client)
        {
            this.clientManager = manager;
            this.client = client;
            Response = new List<MessageBase>();
        }

        public override void Process(SendFile message)
        {
            var clientName = message.Sender;
            var nguoiNhan = message.To;

            if (nguoiNhan == "*")
            {
                foreach (var item in clientManager.GetAll())
                    this.Response.Add(new RecievedFile(clientName, item.TenMay, message.ByteData, message.FileName) { From = clientName, Client = item });
                return;
            }

            if (!clientManager.IsExist(nguoiNhan))
            {
                //Nếu người gửi không tồn tại 
                this.Response.Add(new SendMessageFailed(clientName, "", "Người nhận không tồn tại:" + nguoiNhan));
            }
            else
            {
                this.Response.Add(new RecievedFile(clientName, nguoiNhan, message.ByteData, message.FileName) { From = clientName, Client = clientManager.Get(nguoiNhan) });
            }
        }


        public override void Process(SendMessage message)
        {
            var clientName = message.Sender;
            var nguoiNhan = message.To;

            if (nguoiNhan == "*")
            {
                foreach (var item in clientManager.GetAll())
                    this.Response.Add(new RecievedMessage(item.TenMay, message.Message) { From = clientName, Client = item });
                return;
            }

            if (!clientManager.IsExist(nguoiNhan))
            {
                //Nếu người gửi không tồn tại 
                this.Response.Add(new SendMessageFailed(clientName, message.Message, "Người nhận không tồn tại:" + nguoiNhan));
            }
            else
            {
                this.Response.Add(new RecievedMessage(clientName, message.Message) { From = clientName, Client = clientManager.Get(nguoiNhan) });
            }
        }

        /// <summary>
        /// Server xử lý gói tin ConnectMessageRequest
        /// </summary>
        /// <param name="message"></param>
        override public void Process(ChatLib.MessageModel.ConnectMessageRequest message)
        {
            var clientName = message.Sender;
            if (clientManager.IsExist(clientName))
                //Nếu đã tồn tại client có tên này 
                this.Response.Add(new ConnectMessageFailed(clientName) { Reason = "Name already exists on server" });
            else
            {
                client.TenMay = message.Sender;
                this.Response.Add(new ConnectMessageSuccess(clientName));
                this.clientManager.Add(client);
            }
        }

    }
}
