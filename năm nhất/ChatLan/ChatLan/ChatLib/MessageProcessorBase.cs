using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public class MessageProcessorBase : IMessageProcess
    {
        virtual public void Process(MessageModel.ConnectMessageSuccess message)
        {

        }

        virtual public void Process(MessageModel.ConnectMessageFailed message)
        {

        }

        virtual public void Process(MessageModel.ConnectMessageRequest message)
        {

        }

        virtual public void Process(MessageModel.SendMessage message)
        {

        }

        virtual public void Process(MessageModel.RecievedMessage message)
        {

        }

        virtual public void Process(MessageModel.SendMessageFailed message)
        {

        }


        virtual public void Process(MessageModel.RecievedFile recievedFile)
        {

        }

        virtual public void Process(MessageModel.SendFile sendFile)
        {

        }
    }
}
