using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoMu_bai_1
{
    public class Program
    {
        public static double LuyThua(double x, int n)
        {
            double luyThua = 0; // ket qua cua x^i

            luyThua = 1;
            for (int j = 0; j < n; j++)
            {
                luyThua = luyThua * x;
            }
            return luyThua;
        }

        public static double SoMu(double x, int n)
        {
            var p = 0.0;
            var c = 0.0;
            for (int i = 0; i <= n; i++)
            { 
                p = (1 + i) * LuyThua(x, i);
                c = c + p;
            }

            return c;
        }

        static void Main(string[] args)
        {
        }
    }
}
