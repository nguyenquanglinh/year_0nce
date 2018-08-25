using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class MayKhach : IDisposable
    {
        Socket socKet;
        public string TenMay
        {
            get;
            set;
        }

        public MayKhach(Socket socket)
        {

            this.socKet = socket;
        }


        public void Dispose()
        {
            try
            {
                socKet.Close();
            }
            catch (Exception)
            {

            }
        }

        public byte[] Receive()
        {
            var data = new byte[1024];
            socKet.Receive(data);
            return data;
        }

        internal void Send(byte[] data)
        {
            socKet.Send(data);
        }
    }
}
