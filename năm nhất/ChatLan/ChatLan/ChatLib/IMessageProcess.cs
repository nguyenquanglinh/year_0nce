using ChatLib.MessageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public interface IMessageProcess
    {
        void Process(MessageModel.RecievedMessage message);
        void Process(MessageModel.SendMessageFailed message);
        void Process(MessageModel.SendMessage message);
        void Process(MessageModel.ConnectMessageSuccess message);
        void Process(MessageModel.ConnectMessageFailed message);
        void Process(MessageModel.ConnectMessageRequest message);

        void Process(RecievedFile recievedFile);

        void Process(SendFile sendFile);
    }
}
