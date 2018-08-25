using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InTerFacesExample
{
    public interface GiaoDich
    {
        void hienThiThongTinGiaoDich();
        double laySoLuong();
    }
    class GiaoDichHangHoa : GiaoDich
    {
        private string ma_hang_hoa;
        private string ngay;
        private double so_luong;
        public GiaoDichHangHoa()
        {
            ma_hang_hoa = "";
            ngay = "";
            so_luong = 0.0;
        }

        public GiaoDichHangHoa(string c, string d, double a)
        {
            ma_hang_hoa = c;
            ngay = d;
            so_luong = a;
        }

        public double laySoLuong()
        {
            return so_luong;
        }

        public void hienThiThongTinGiaoDich()
        {
            Console.WriteLine("Ma hang hoa: {0}", ma_hang_hoa);
            Console.WriteLine("Ngay giao dich: {0}", ngay);
            Console.WriteLine("So luong: {0}", laySoLuong());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface trong C#");
            Console.WriteLine("Vi du minh hoa interface");
            Console.WriteLine("--------------------------");

            //tao cac doi tuong GiaoDichHangHoa
            GiaoDichHangHoa t1 = new GiaoDichHangHoa();
            GiaoDichHangHoa t2 = new GiaoDichHangHoa("002", "9/10/2012", 451900.00);
            t1.hienThiThongTinGiaoDich();
            t2.hienThiThongTinGiaoDich();
            Console.WriteLine(t2.laySoLuong());

            Console.ReadKey();
        }
    }
}
