using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatlib.MessageModel
{
    public class MessagerProcessorBase : IMessageProcess
    {


        virtual public void Process(MessagerModel.ConnectMessageRequest connectMessageRequest)
        {
        }

        virtual public void Process(MessagerModel.ConnectMessageSuccess connectMessageSuccess)
        {
        }

        virtual public void Process(MessagerModel.ConnecMessageFaile connecMessageFaile)
        {
        }

        virtual public void Process(MessagerModel.SendMessage sendMessage)
        {
        }

        virtual public void Process(MessagerModel.SendLocationPlayerClick sendLocationPlayerClick)
        {
        }

        virtual public void Process(MessagerModel.RecieveLoactionPlayerClick recieveLoactionPlayerClick)
        {
        }

        virtual public void Process(MessagerModel.RecievedMessage recievedMessage)
        {
        }

        virtual public void Process(MessagerModel.ReceiFileBig receiFileBig)
        {
        }

        virtual public void Process(MessagerModel.SendMessageFalse sendMessageFalse)
        {
        }

        virtual public void Process(MessagerModel.SendFileBig sendFileBig)
        {
        }

        virtual public void Process(MessagerModel.SenFile senFile)
        {
        }

        virtual public void Process(MessagerModel.RecievedFile recievedFile)
        {
        }
    }
}
