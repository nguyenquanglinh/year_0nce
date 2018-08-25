using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chatlib;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using Chatlib.MessagerModel;

namespace ChatCaro
{
    public class ClientChat
    {
        Socket client;

        public List<IMessageProcess> Processor { get; set; }

        public int Port { get; set; }

        public int port { get; set; }

        public ClientChat(int Port)
        {
            this.Port = Port;
            Processor = new List<IMessageProcess>();
        }

        public void Connect(string name)
        {
            var IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                Send(new ConnectMessageRequest(name));
            }
            catch (Exception)
            {
                return;
            }
            Thread listen = new Thread(WaitMessage);
            listen.IsBackground = true;
            listen.Start();
        }

        private void WaitMessage()
        {
            try
            {
                while (true)
                {
                    var data = new byte[1024];
                    client.Receive(data);
                    var mesage = TryConvertObject.SwithToMessager(data);
                    foreach (var item in Processor)
                    {
                        mesage.Accept(item);
                    }
                }
            }
            catch (Exception)
            {
                client.Close();
            }
        }

        public void Send(MessageBaser message)
        {
            var data = TryConvertObject.SwithToBinnary(message);
            this.client.Send(data);
        }
    }
}
