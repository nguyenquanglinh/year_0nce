ăeusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // commit thử
            Console.Write("1:đôi đô C=>K\t\t\t");
            Console.WriteLine(" 2:đôi đô K=>C");
            Console.Write("3:đôi Km=>m\t\t\t");
            Console.WriteLine(" 4:đôi m=>Km");

            ulong sô = ulong.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");
            if (sô == 1)
            {
                Console.Write("nhâp đô C= ");
                double c = double.Parse(Console.ReadLine());
                if (c >= 0)
                {
                    double k = c + 273;
                    Console.Write("đô k = " + k);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if (sô == 2)
            {
                Console.Write("nhâp đô K= ");
                double k = int.Parse(Console.ReadLine());
                if (k >= 0)
                {
                    double c = k - 273;
                    Console.Write("đô c= " + c);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if (sô == 3)
            {
                Console.Write("nhâp sô km= ");
                Double km = double.Parse(Console.ReadLine());
                if (km >= 0)
                {
                    double m = km * 1000;
                    Console.Write("sô m= " + m);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if (sô == 4)
            {
                Console.Write("nhâp sô m= ");
                double m = double.Parse(Console.ReadLine());
                if (m >= 0)
                {
                    Double km = (m * 1.0 / 1000);
                    Console.Write("sô km= " + km);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if (sô == 5)
            {
                Console.Write("nhâp sô km/h= ");
                double a = Double.Parse(Console.ReadLine());
                if (a >= 0)
                {
                    double b = a * 1000 * 1.0 / 3600;
                    Console.Write("sô m/s la " + b);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if (sô == 6)
            {
                Console.Write("nhâp sô m/s= ");
                double a = double.Parse(Console.ReadLine());
                if (a >= 0)
                {
                    double b = a * 3600 * 1.0 / 1000;
                    Console.Write("sô km/h= " + b);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if (sô == 7)
            {
                Console.Write("nhâp sô HP= ");
                double hp = double.Parse(Console.ReadLine());
                if (hp >= 0)
                {
                    double b = hp * 1.0 * 0.745699872;
                    Console.Write("sô KW= " + b);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if (sô == 8)
            {
                Console.Write("nhâp sô KW= ");
                double kw = double.Parse(Console.ReadLine());
                if (kw >= 0)
                {
                    double hp = kw * 1.0 / 0.745699872;
                    Console.Write("sô hp= " + hp);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if (sô == 9)
            {
                Console.Write("nhâp sô m2= ");
                double m2 = double.Parse(Console.ReadLine());
                if(m2>=0)
                {
                    double km2 = m2* 1.0/1000000;
                    Console.Write("sô km2=" + km2);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if(sô==10)
            {
                Console.Write("nhâp sô km2= ");
                double km2 = double.Parse(Console.ReadLine());
                if(km2>=0)
                {
                    double m2 = km2*1000000*1.0;
                    Console.Write("sô m2= " + m2);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if(sô==11)
            {
                Console.Write("nhâp sô m2= ");
                double m2 = double.Parse(Console.ReadLine());
                if(m2>=0)
                {
                    double cm2 = m2 * 10000 * 1.0;
                    Console.Write("sô cm2= " + cm2);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if(sô==12)
            {
                Console.Write("nhâp sô cm2= ");
                double cm2 = double.Parse(Console.ReadLine());
                if(sô>=0)
                {
                    double m2 = cm2 * 1.0 / 10000;
                    Console.Write("sô m2= " + m2);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if(sô==13)
            {
                Console.Write("nhâp sô cm= ");
                double cm = double.Parse(Console.ReadLine());
                if(cm>=0)
                {
                    double In = cm * 1.0 * 0.3937007874;
                    Console.Write("sô in= " + In);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if(sô==14)
            {
                Console.Write("nhâp sô in= ");
                double In = double.Parse(Console.ReadLine());
                if(In>=0)
                {
                    double cm = In * 1.0 / 0.3937007874;
                    Console.Write("sô cm= " + cm);
                }
                else Console.WriteLine("ban đa nhâp sai xin bat đâu lai_Q.linh");
            }
            if(sô==15)
            {
                Console.Write("nhâp sô ft= ");
                double a = double.Parse(Console.ReadLine());
                if(a>=0)
                {
                    double b=
                }
            }
            Console.ReadLine();
        }
    }
}
