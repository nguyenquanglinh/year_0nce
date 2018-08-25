using ChatLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 2302;
            new Server.MayChu(port).Start();
            Logging.Info("Server started at:" + port);
            Console.ReadLine();
        }
    }
}
