using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChessCaro
{
    public class SocKetManager
    {

        //Client
        Socket client;

        public bool ConnecServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(iep);
                return true;
            }
            catch
            {

                return false;
            }
        }

        //Sever
        Socket server;
        public void CreatServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(iep);
            server.Listen(10);
            Thread acceptClient = new Thread(() =>
            {
                client = server.Accept();
            });
            acceptClient.IsBackground = true;
            acceptClient.Start();
        }

        //Both
        public string IP = "127.0.0.1";
        public int PORT = 9999;
        public bool IsServer = true;
        //Gửi
        public bool Send(object v)
        {
            byte[] senData = SerializeData(v);

            {
                return SendData(client, senData);
            }
        }

        //nhận
        public object Receive()
        {
            byte[] receive = new byte[1024];
            bool isOk = ReceivieData(client, receive);
            return DeserializeData(receive);
        }

        //gửi dữ liệu
        bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;
        }

        //nhận dữ liệu
        bool ReceivieData(Socket target, byte[] data)
        {
            return target.Receive(data) == 1 ? true : false;
        }

        //chuyển đổi giữ liệu text sang byte
        public byte[] SerializeData(object v)
        {
            var ms = new MemoryStream();
            var bf1 = new BinaryFormatter();
            bf1.Serialize(ms, 0);
            return ms.ToArray();
        }

        //chuyển đổi giữ liệu byte sang text
        public object DeserializeData(byte[] v)
        {
            var ms = new MemoryStream(v);
            var bf1 = new BinaryFormatter();
            return bf1.Deserialize(ms);
        }

        //lấy địa chỉ ipv4
        public string GetLocalIPV4(NetworkInterfaceType v)
        {

            string outPut = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == v && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            outPut = ip.Address.ToString();
                        }
                    }
                }
            }
            return outPut;
        }
    }
}
