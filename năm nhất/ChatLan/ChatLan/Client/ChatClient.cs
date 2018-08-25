using ChatLib;
using ChatLib.MessageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class MessageRecivedEventArgs : EventArgs
    {
        public MessageBase Message { get; set; }
    }


    class ChatClient
    {

        public List<IMessageProcess> Processors { get; set; }

        IPEndPoint ip;
        Socket client;
        int Port = 2302;


        public event EventHandler<MessageRecivedEventArgs> MessageRecieved;

        public ChatClient(int port)
        {
            this.Port = port;
            Processors = new List<IMessageProcess>();
        }

        public void Connect(string name)
        {
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(ip);
                Send(new ConnectMessageRequest(name));
            }
            catch (Exception ex)
            {
                Logging.Error("Error on connect", ex);
                return;
            }
            Thread listen = new Thread(WaitMessage);
            listen.IsBackground = true;
            listen.Start();

        }


        public void Send(MessageBase message)
        {
            var byteArray = ObjectConvert.Object2Binary(message);
            Logging.Debug("Send to server, data leng:" + byteArray.Length);
            this.client.Send(byteArray);
        }

        void WaitMessage()
        {
            try
            {
                while (true)
                {
                    var data = new byte[1024];
                    client.Receive(data);
                    var message = ObjectConvert.Binnary2Object(data);
                    foreach (var item in this.Processors)
                    {
                        message.Accept(item);
                    }

                    Logging.Info("Recieved data from server, data leng:" + data.Length);
                }
            }
            catch (Exception ex)
            {
                Logging.Error("Error on WaitMessage", ex);
                client.Close();
            }
        }

    }
}
