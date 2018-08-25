using ChatLib;
using ChatLib.MessageModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class MayChu
    {
        int Port = 2302;

        private ClientManager clientManager = ClientManager.Instance;

        public MayChu(int port)
        {
            this.Port = port;
        }

        public void Start()
        {
            Connect();
        }

        /// <summary>
        /// Start server và bắt đầu lắng nghe từ client
        /// </summary>
        void Connect()
        {
            var ip = new IPEndPoint(IPAddress.Any, Port);
            Socket Sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            Sever.Bind(ip);
            Logging.Info("Server started");
            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Sever.Listen(100);
                        var client = Sever.Accept();
                        var mayKhach = new MayKhach(client);
                        Logging.Info("Client connected");
                        Thread receive = new Thread(NhanTinVe);
                        receive.IsBackground = true;
                        receive.Start(mayKhach);
                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, Port);
                    Sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });

            listen.IsBackground = true;
            listen.Start();
        }

        /// <summary>
        /// Lấy dữ liệu từ máy khác
        /// </summary>
        /// <param name="obj"></param>
        void NhanTinVe(object obj)
        {
            var client = (MayKhach)obj;
            try
            {
                while (true)
                {
                    var data = client.Receive();
                    var message = ObjectConvert.Binnary2Object(data);
                    Logging.Debug("Recieved data from:" + client.TenMay);
                    var processor = new ServerMessageProcessor(clientManager, client);
                    message.Accept(processor);
                    foreach (var item in processor.Response)
                    {
                        if (item.Client != null)
                            SendToClient(item.Client as MayKhach, item);
                        else
                            SendToClient(client, item);
                    }
                }
            }
            catch
            {
                clientManager.Remove(client);
            }
        }

        private void SendToClient(MayKhach client, MessageBase message)
        {
            Logging.Debug("Send to:" + message.ToString());
            client.Send(ObjectConvert.Object2Binary(message));
        }

    }
}
