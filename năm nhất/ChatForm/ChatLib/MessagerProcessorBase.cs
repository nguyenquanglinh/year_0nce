using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public abstract class MessagerProcessorBase : IMessageProcess
    {
        virtual public void Process(MessageModel.ConnectMessageSuccess message) { }

        virtual public void Process(MessageModel.ConnecMessageFaile message) { }

        virtual public void Process(MessageModel.ConnectMessageRequest message) { }

        virtual public void Process(MessageModel.SendMessage message) { }

        virtual public void Process(MessageModel.RecievedMessage message) { }

        virtual public void Process(MessageModel.RecievedFile message) { }

        virtual public void Process(MessageModel.SendMessageFalse message) { }

        virtual public void Process(MessageModel.SendFile message) { }


        //tìm người chơi
        virtual public void Process(MessageModel.SendFindPlayer sendFindPlayer)
        {
        }
        //đã tìm thấy người chơi
        virtual public void Process(MessageModel.ReceiFindPlayer receiFindPlayer)
        {
        }

        //gửi lời mời đến 1 người
        virtual public void Process(MessageModel.SendInvation message)
        {

        }

        //quyết định của người chơi
        virtual public void Process(MessageModel.ReciveInvation message)
        {

        }



        virtual public void Process(MessageModel.SendFileBig sendFileBig)
        {

        }

        virtual public void Process(MessageModel.SendClientClose clientClose)
        {

        }

        virtual public void Process(MessageModel.ReceiveClientClose receiClientClose)
        {

        }
    }
}
