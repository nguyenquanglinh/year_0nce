using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTamGiacThuocTinh
{
    class Tamgiac
    {
        public Tamgiac() { }
        double canhA, canhB, canhC;
        public double CanhA
        {
            get
            {
                return canhA;
            }
            set
            {
                canhA = value;
                if (canhA < 0)
                    throw new Exception("nhap sai");
            }
        }
        public double CanhB
        {
            get
            {
                return canhB;
            }
            set
            {
                canhB = value;
                if (value < 0)
                    throw new Exception("nhap sai ");
            }
        }
        public double CanhC
        {
            get
            {
                return canhC;
            }
            set
            {
                canhC = value;
                if (value < 0)
                    throw new Exception("nhap sai");
            }
        }
        public Tamgiac(double c1,double c2,double c3)
        {
            CanhA = c1;
            CanhB = c2;
            CanhC = c3;
            if (CanhA + CanhB <= CanhC || CanhA + CanhC <= CanhB || CanhB + CanhC <= CanhA)
                throw new Exception("tam giac khong ton tai ");
        }
        
        public double DienTich()
        {
            var p = (CanhA + CanhB + CanhC) * 1.0 / 2;
            var x = p * (p - CanhA) * (p - CanhB) * (p - CanhC);
           double dienTich = Math.Sqrt(x)*1.0;
            return dienTich;
        }
        public double ChuVi
        {
            get
            {
                var chuVi = CanhA + CanhB + CanhC;
                return chuVi;
            }
        }
        public Tamgiac Nhap()
        {
            Console.Write("nhap do dai canh 1 ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("nhap do dai canh 2 ");
            int c2 = int.Parse(Console.ReadLine());
            Console.Write("nhap do dai canh 3 ");
            int c3 = int.Parse(Console.ReadLine());
            var tG = new Tamgiac(c1, c2, c3);
            return tG;
        }
        public void InManHinh()
        {
            Console.WriteLine("canh 1 ", +CanhA);
            Console.WriteLine("Canh 2 ", +CanhB);
            Console.WriteLine("canh 3", +CanhC);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Tamgiac();
            var x = s.Nhap();
            Console.WriteLine(x.DienTich());
            Console.WriteLine(x.ChuVi);
            x.InManHinh();
            Console.ReadKey();
        }
    }
}
