using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSinhVien
{
    class SinhVien
    {
        public string Ten
        {
            get
            {
                return ten.ToUpper();
            }
            set
            {
                ten = value;
                if (string.IsNullOrEmpty(value))
                    throw new Exception("ten khong hop le");
            }
        }
        string ten, diaChi, tuoi;
        int toan, ly, hoa;
        public SinhVien(string tenSv, string diaChiSv, int dToan, int dLy, int dHoa, string tuoiSv)
        {
            Ten= tenSv;
            if (string.IsNullOrEmpty(ten))
                throw new Exception("ten phai khac rong");
            diaChi = diaChiSv;
            toan = dToan;
            hoa = dHoa;
            ly = dLy;
            tuoi = tuoiSv;
        }
        public double Diem()
        {
            double tb;
            tb = (toan + ly + hoa) / 3;
            return tb;
        }
        public void InManHinh()
        {
            Console.WriteLine(ten);
            Console.WriteLine(diaChi);
        }
        public SinhVien NhapThongTin()
        {
            Console.Write("nhap ten sinh vien ");
            string ten = Console.ReadLine();
            Console.Write("Nhap dia chi sinh vien ");
            string diaChi = Console.ReadLine();
            Console.Write("nhap tuoi sinh vien ");
            string tuoi = Console.ReadLine();
            Console.Write("nhap diem mon toan ");
            int dToan = int.Parse(Console.ReadLine());
            Console.Write("nhap diem mon ly ");
            int dLy = int.Parse(Console.ReadLine());
            Console.Write("nhap diem mon hoa ");
            int dHoa = int.Parse(Console.ReadLine());
            var sV1 = new SinhVien(ten, diaChi, dToan, dLy, dHoa, tuoi);
            return sV1;
        }
        static void Main(string[] args)
        {
            string ten = "a", diaChi = "b", tuoi = "c";
            int dLy = 0, dHoa = 0, dToan = 0;
            var s = new SinhVien(ten, diaChi, dToan, dLy, dHoa, tuoi);
            var x = s.Ten;
            s.Ten = "";
            //var x = s.NhapThongTin();
            //x.InManHinh();
            //Console.WriteLine(x.Diem());
            Console.ReadLine();
        }
    }
}
