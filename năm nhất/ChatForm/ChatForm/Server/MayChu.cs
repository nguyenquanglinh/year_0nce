using ChatLib;
using ChatLib.MessageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    class MayChu
    {
        private int Port;

        ClientManager clientManager = ClientManager.Instance;

        public MayChu(int Port)
        {
            this.Port = Port;
        }

        internal void Connect()
        {
            var IP = new IPEndPoint(IPAddress.Any, Port);
            var sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sever.Bind(IP);
            Console.WriteLine("sever connected");
            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        sever.Listen(1000);
                        var mayKhach = new MayKhach(sever.Accept());
                        Console.WriteLine("client connected ");
                        Thread receive = new Thread(NhanTinNhan);
                        receive.IsBackground = true;
                        receive.Start(mayKhach);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("lỗi máy chủ " + ex);
                    Console.WriteLine("khắc phục lỗi==>> tạo lại máy chủ");
                    IP = new IPEndPoint(IPAddress.Any, Port);
                    sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        private void NhanTinNhan(object obj)
        {
            var client = (MayKhach)obj;

            try
            {
                while (true)
                {
                    var data = client.Receive();
                    var messager = TryConvertObject.SwithToMessager(data);
                    var processor = new SeverMessageProcessor(client, clientManager);
                    messager.Accept(processor);
                    foreach (var item in processor.ListReiceveMassager)
                    {
                        if (item.Client != null)
                            SendToClient(item.Client as MayKhach, item);
                        else
                            SendToClient(client, item);
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("exception : client close " + client.TenMay);
                clientManager.Remove(client);
            }
        }
        private void SendToClient(MayKhach client, MessageBase message)
        {
            client.Send(TryConvertObject.SwithToBinnary(message));
        }
    }
}
