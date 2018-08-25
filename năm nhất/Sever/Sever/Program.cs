using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sever
{
    class Program
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;
        static ASCIIEncoding encoding = new ASCIIEncoding();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                try
                {
                    IPAddress address = IPAddress.Parse("127.0.0.1");
                    TcpListener listener = new TcpListener(address, PORT_NUMBER);
                    // 1. listen
                    listener.Start();
                    Console.WriteLine("Server bắt đầu kết nối tới IEP là:  " + listener.LocalEndpoint);
                    Console.WriteLine("Đang chờ kết nối ...");
                    Socket socket = listener.AcceptSocket();
                    Console.WriteLine("Kết nối nhận được từ " + socket.RemoteEndPoint);

                    // 2. receive
                    byte[] data = new byte[BUFFER_SIZE];
                    socket.Receive(data);
                    string str = encoding.GetString(data).ToString();
                    if (str[0] == '0')
                        Console.WriteLine("client đã ngắt kết nối");
                    var ss = str.ToString().Split('\0');
                    Console.WriteLine("b:" + encoding.GetString(data));
                    // 3. send
                    Console.Write("a :");
                    var s = Console.ReadLine();
                    socket.Send(encoding.GetBytes(s));
                    if (s == "0")
                    {
                        socket.Close();
                        listener.Stop();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
            }
        }
    }
}
