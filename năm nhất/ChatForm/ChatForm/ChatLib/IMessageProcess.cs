using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    /// <summary>
    /// giao diện cho các lớp xử lý messagebase
    /// </summary>
    public interface IMessageProcess
    {
        //yêu cầu kết nối đên server thành công
        void Process(MessageModel.ConnectMessageRequest connectMessageRequest);

        //kết nối thành công tới server
        void Process(MessageModel.ConnectMessageSuccess connectMessageSuccess);

        //gửi tin nhắn lỗi
        void Process(MessageModel.ConnecMessageFaile connecMessageFaile);

        //gửi tin nhắn
        void Process(MessageModel.SendMessage sendMessage);

        //nhận tin nhắn
        void Process(MessageModel.RecievedMessage recievedMessage);

        //gửi tin nhắn lỗi
        void Process(MessageModel.SendMessageFalse sendMessageFile);

       //gửi tin nhắn
        void Process(MessageModel.SendFile senFile);

        //nhận tin nhắn
        void Process(MessageModel.RecievedFile recievedFile);

        //gửi lời mời chơi game đến 1 người
        void Process(MessageModel.SendInvation sendInvation);
        //trả lời mời chơi game
        void Process(MessageModel.ReciveInvation reciveDecLinedInvation);
        //tìm bạn chơi
        void Process(MessageModel.SendFindPlayer sendFindPlayer);
        //trả lại ds người chơi
        void Process(MessageModel.ReceiFindPlayer receiFindPlayer);

        void Process(MessageModel.SendFileBig sendFileBig);

        void Process(MessageModel.SendClientClose clientClose);

        void Process(MessageModel.ReceiveClientClose receiClientClose);
    }
}
