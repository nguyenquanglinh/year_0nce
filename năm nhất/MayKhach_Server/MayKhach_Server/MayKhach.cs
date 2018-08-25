using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MayKhach_Server
{
    public class MayKhach
    {
        public MayKhach(Socket mayKhach)
        {
            if (SocKet == null)
                this.SocKet = mayKhach;
        }

        public string TenMay
        {
            get;
            set;
        }

        Socket socKet;

        public Socket SocKet
        {
            get
            {
                return socKet;
            }
            set
            {
                if (socKet == null)
                    socKet = value;
            }
        }
         
    }
}
