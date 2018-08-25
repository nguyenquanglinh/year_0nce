using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatlib
{
    public interface IMessageProcess
    {
        void Process(MessagerModel.ConnectMessageRequest connectMessageRequest);

        void Process(MessagerModel.ConnectMessageSuccess connectMessageSuccess);

        void Process(MessagerModel.ConnecMessageFaile connecMessageFaile);

        void Process(MessagerModel.SendMessage sendMessage);

        void Process(MessagerModel.SendLocationPlayerClick sendLocationPlayerClick);

        void Process(MessagerModel.RecieveLoactionPlayerClick recieveLoactionPlayerClick);

        void Process(MessagerModel.RecievedMessage recievedMessage);

        void Process(MessagerModel.ReceiFileBig receiFileBig);

        void Process(MessagerModel.SendMessageFalse sendMessageFalse);

        void Process(MessagerModel.SendFileBig sendFileBig);

        void Process(MessagerModel.SenFile senFile);

        void Process(MessagerModel.RecievedFile recievedFile);
    }
}
