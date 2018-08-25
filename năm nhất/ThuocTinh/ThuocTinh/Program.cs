using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuocTinhHop
{
    class Hop
    {
        int chieuCao = 0, chieuDai = 0, chieuRong = 0;
        public Hop() { }
        public int ChieuDai
        {
            get
            {
                return chieuDai;
            }
            set
            {
                chieuDai = value;
                if (chieuDai <= 0)
                    throw new Exception("nhap sai ");
            }
        }
        public int ChieuCao
        {
            get
            {
                return chieuCao;
            }
            set
            {
                chieuCao = value;
                if (chieuCao <= 0)
                    throw new Exception("Nhap sai");
            }
        }
        public int ChieuRong
        {
            get
            {
                return chieuRong;
            }
            set
            {
                chieuRong = value;
                if (chieuRong <= 0)
                    throw new Exception("nhap sai ");
            }
        }
        public double TheTich
        {
            get
            {
                double v = 0;
                v = chieuDai * ChieuCao * chieuRong;
                return v;
            }
        }
        public
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new Hop();
            Console.Write("chieu cao cua hop la ");
            int c = int.Parse(Console.ReadLine());
            a.ChieuCao = c;
            Console.Write("chieu rong cua hop la ");
            int r = int.Parse(Console.ReadLine());
            a.ChieuRong = r;
            Console.Write("chieu dai cua hop la ");
            int d = int.Parse(Console.ReadLine());
            a.ChieuDai = d;
            var s = a.TheTich;
            Console.WriteLine("the tich hop la {0} ", s);
            Console.ReadKey();
        }
    }
}
