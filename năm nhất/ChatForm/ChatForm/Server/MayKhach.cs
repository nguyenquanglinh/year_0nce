using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class MayKhach
    {
        Socket Socket;

        public string TenMay { get; set; }

        public MayKhach(Socket client)
        {
            this.Socket = client;
        }
        /// <summary>
        /// loại bỏ máy khách hiện tại
        /// </summary>
        public void Dispose()
        {
            try
            {
                Socket.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("lỗi đóng kết nối máy khách " + ex);
            }
        }
        /// <summary>
        /// nhận tin nhắn
        /// </summary>
        /// <returns></returns>
        public byte[] Receive()
        {
            var data = new byte[1024*5];
            Socket.Receive(data);

            return data;
        }
        /// <summary>
        /// gửi dữ liệu đi
        /// </summary>
        /// <param name="data"></param>
        public void Send(byte[] data)
        {
            Socket.Send(data);
        }

    }
}
