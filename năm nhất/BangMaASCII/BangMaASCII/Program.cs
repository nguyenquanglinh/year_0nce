using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangMaASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)
            {

                string c = Convert.ToString((char)i);
                Console.Write(c + "\t");

            }
            var d = 'n';
            char  e='g';
            int b = (int)d;
       //     int a = Int16.Parse(e);
            Console.Write(b);
       //     Console.Write(a);
        }
    }
}
