using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHop
{
    class Hop
    {
        int chieuDai;
        int chieuRong;
        int chieuCao;

        public Hop()
        {
        }
        public Hop(int cao, int rong, int dai)
        {
            chieuCao = cao;
            chieuDai = rong;
            chieuRong = dai;
        }
        public double TheTich()
        {
            var theTich = 0;
            theTich = chieuCao * chieuDai * chieuRong;
            return theTich;
        }
        public Hop Nhap()
        {
            Console.Write("nhap chieu cao cua hop ");
            int chieuCao = int.Parse(Console.ReadLine());
            Console.Write("nhap chieu rong cua hop ");
            int chieuRong = int.Parse(Console.ReadLine());
            Console.Write("nhap chieu dai cua hop ");
            int chieuDai = int.Parse(Console.ReadLine());
            var hop = new Hop(chieuCao, chieuRong, chieuDai);
            return hop;
        }

        static void Main(string[] args)
        {
         int cao=0, rong=0, dai=0;
            var b = new Hop(cao, rong, dai);
            
            var r = b.Nhap();
            Console.WriteLine(r.TheTich());
            Console.ReadKey();
        }

    }
}
