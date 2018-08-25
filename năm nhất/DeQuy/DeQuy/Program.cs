using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQuy
{
    class Program
    {
        static int GiaiThua(int a)
        {
            if (a == 1)
                return a;
            else
                return a * GiaiThua(a - 1);
        }

        static int SoHangThuNTrongDay(int n)
        {
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;
            else
            {
                return SoHangThuNTrongDay(n - 1) + SoHangThuNTrongDay(n - 2);
            }
        }



        static void Main(string[] args)
        {
            while (true)
            {


                Console.Write("nhap n  ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    return;
                var y = SoHangThuNTrongDay(n);

                //var x =GiaiThua(n);
                Console.WriteLine(y);
                Console.ReadLine();
            }
        }
    }
}
