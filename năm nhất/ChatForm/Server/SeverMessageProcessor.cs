using ChatLib;
using ChatLib.MessageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Server
{
    class SeverMessageProcessor : MessagerProcessorBase
    {
        private MayKhach client;
        private ClientManager clientManager;
        public List<MessageBase> ListReiceveMassager { get; set; }
        public SeverMessageProcessor(MayKhach client, ClientManager clientManage)
        {
            this.clientManager = clientManage;
            this.client = client;
            ListReiceveMassager = new List<MessageBase>();
        }
        //gửi message
        public override void Process(ChatLib.MessageModel.SendMessage message)
        {
            var clientName = message.NameSender;
            var nguoiNhan = message.SendTo;
            //không tồn tại người nhận
            if (!clientManager.IsCounterName(message.NameSender))
            {
                this.ListReiceveMassager.Add(new ChatLib.MessageModel.SendMessageFalse(clientName, message.Message, "người nhận không tồn tại " + nguoiNhan));
            }
            //gửi tin nhăn đi
            else if (message.IsLocation == false)
            {
                this.ListReiceveMassager.Add(new ChatLib.MessageModel.RecievedMessage(clientName, message.Message, false) { From = clientName, Client = clientManager.Get(nguoiNhan) });
            }
            //gửi tọa độ
            else

                this.ListReiceveMassager.Add(new ChatLib.MessageModel.RecievedMessage(clientName, message.Message, true) { From = clientName, Client = clientManager.Get(nguoiNhan) });
        }
        //tìm người chơi
        public override void Process(ChatLib.MessageModel.SendFindPlayer sendFindPlayer)
        {
            var ListMayKhach = clientManager.GetUserPlayerNew(sendFindPlayer.NameSender);

            this.ListReiceveMassager.Add(new ChatLib.MessageModel.ReceiFindPlayer(client.TenMay, ListMayKhach));
        }

        //gửi lời mời
        public override void Process(ChatLib.MessageModel.SendInvation sendInvation)
        {
            var client = clientManager.Get(sendInvation.From);
            this.ListReiceveMassager.Add(new ChatLib.MessageModel.SendInvation(sendInvation.NameSender, sendInvation.From) { Client = client });
        }

        public override void Process(ChatLib.MessageModel.SendClientClose clientClose)
        {
            this.ListReiceveMassager.Add(new ReceiveClientClose(clientClose.NameSender, clientClose.From) { Client = clientManager.Get(clientClose.From) });
        }

        public override void Process(ChatLib.MessageModel.ReciveInvation message)
        {
            var client = clientManager.Get(message.From);
            ListReiceveMassager.Add(new ChatLib.MessageModel.ReciveInvation(message.NameSender, message.From, message.IsInvation) { Client = client });
        }


        public override void Process(ConnectMessageRequest message)
        {
            var clientName = message.NameSender;
            if (clientManager.IsCounterName(clientName))
                this.ListReiceveMassager.Add(new ConnecMessageFaile(clientName) { Exception = "tồn tại tên trên sever " + message.NameSender });
            else
            {
                client.TenMay = message.NameSender;
                this.ListReiceveMassager.Add(new ConnectMessageSuccess(clientName));
                this.clientManager.Add(client);
            }
        }

        public override void Process(ChatLib.MessageModel.SendFile message)
        {
            var clientName = message.NameSender;
            var nguoiNhan = message.SendTo;

            if (!clientManager.IsCounterName(nguoiNhan))
            {
                //Nếu người gửi không tồn tại 
                this.ListReiceveMassager.Add(new SendMessageFalse(clientName, "không thể gửi file", "Ex:không có người nhận"));
            }
            else
            {
                this.ListReiceveMassager.Add(new RecievedFile(clientName, nguoiNhan, message.FileName, message.ByteData) { Client = clientManager.Get(nguoiNhan) });
            }
        }


    }

}

