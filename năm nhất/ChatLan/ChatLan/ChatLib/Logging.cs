using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public class Logging
    {
        public static void Info(string message)
        {
            Console.WriteLine("INFO: " + message);
        }

        public static void Error(string message, Exception ex)
        {
            Console.WriteLine("ERROR: " + message + " ex:" + ex.ToString());
        }

        public static void Debug(string message)
        {
            Console.WriteLine("DEBUG: " + message);
        }
    }
}
