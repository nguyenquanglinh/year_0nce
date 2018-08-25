using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuocTinhSV
{
    public class SinhVien
    {
        string ten, diaChi;
        int toan, ly, hoa, tuoi;
        public string Ten
        {
            get
            {
                return ten;
            }
            set
            {
                ten = value;
                if (string.IsNullOrEmpty(value))
                    throw new Exception("khong ton tai");
            }
        }
        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public int DToan
        {
            get
            {
                return toan;
            }
            set
            {
                toan = value;
                if (value < 0 || value > 10)
                    throw new Exception("nhap sai ");
            }
        }
        public int DLy
        {
            get
            {
                return ly;
            }
            set
            {
                ly = value;
                if (value < 0 || value > 10)
                    throw new Exception("nhap sai ");
            }
        }
        public int DHoa
        {
            get
            {
                return hoa;
            }
            set
            {
                hoa = value;
                if (value < 0 || value > 10)
                    throw new Exception("nhap sai ");
            }
        }
        public int Tuoi
        {
            get
            {
                return tuoi;
            }
            set
            {
                tuoi = value;
                if (value < 0 || value > 100)
                    throw new Exception("nhap sai ");
            }
        }
        public double TB
        {
            get
            {
                var tb = 0;
                tb = (DToan + DLy + DHoa) / 3;
                return tb;
            }
        }
        public SinhVien(string tenSv, string diaChiSv, int dToan, int dLy, int dHoa, int tuoiSv)
        {
            Ten = tenSv;
            DiaChi = diaChiSv;
            DToan = dToan;
            DHoa = dHoa;
            DLy = dLy;
            Tuoi = tuoi;
        }
        public void InManHinh()
        {
            var s = "ten: " + Ten + "\t" + "  dia chi: " + DiaChi + "\t" + "  tuoi: " + tuoi;
            Console.WriteLine(s);
        }
        public void Nhap()
        {
            Console.Write("nhap ten sinh vien ");
            Ten = Console.ReadLine();
            Console.Write("Nhap dia chi sinh vien ");
            DiaChi = Console.ReadLine();
            Console.Write("nhap tuoi sinh vien ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("nhap diem mon toan ");
            DToan = int.Parse(Console.ReadLine());
            Console.Write("nhap diem mon ly ");
            DLy = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon hoa ");
            DHoa = int.Parse(Console.ReadLine());
        }
        public Random x = new Random();
        public void Random()
        {

            var ho = new string[] { "nguyen", "tran", "dinh", "pham", "ngo", "ta", "duong" };
            var dem = new string[] { "van", "thi" };
            var ten = new string[] { "long", "thu", "cuc", "an", "ba", "bon", "nam" };
            var xa = new string[] { "Ycuong", "Yphuc", "yloc", "Ytien", "yNham" };
            var Tinh = new string[] { "ND", "NB", "HN", "TN", "QB", "QT" };
            Ten = ho[x.Next(0, ho.Length)] + " " + dem[x.Next(0, dem.Length)] + " " + ten[x.Next(0, ten.Length)] + " ";
            DiaChi = xa[x.Next(0, xa.Length)] + " " + Tinh[x.Next(0, Tinh.Length)];
            DToan = x.Next(0, 10);
            DLy = x.Next(0, 10);
            DHoa = x.Next(0, 10);
            Tuoi = x.Next(18, 55);
        }
        public SinhVien()
        {
        }

    }
    public class Program
    {
        public static List<SinhVien> XoaTen(List<SinhVien> a, string ten)
        {

            string s = ten;
            for (int i = 0; i < a.Count; i++)
            {
                var t = a[i].Ten;
                var y = t.Trim().Split(' ').Last();

                if (s == y)
                {
                    a.RemoveAt(i);
                    i--;
                }
            }
            return a;
        }
        public static List<SinhVien> TimTen(List<SinhVien> a)
        {
            var b = new List<SinhVien>();
            Console.Write("nhap ten sinh vien can tim: ");
            string s = Console.ReadLine();
            for (int i = 0; i < a.Count; i++)
            {
                var t = a[i].Ten;
                var y = t.Split(' ');
                foreach (var item in y)
                {
                    if (s == item)
                    {
                        b.Add(a[i]);
                    }
                }
            }
            return b;
        }
        public static List<SinhVien> ThemTen(List<SinhVien> a)
        {
            Console.Write("nhap so sinh vien can nhap them ");
            int soThem = int.Parse(Console.ReadLine());
            Console.WriteLine("so sinh vien vua them la ");
            for (int i = 0; i < soThem; i++)
            {
                var sv = new SinhVien();
                sv.Random();
                a.Add(sv);
            }
            return a;
        }
        static void Main(string[] args)
        {
            var a = new List<SinhVien>();
            for (int i = 0; i < 4; i++)
            {
                var sv = new SinhVien();
                sv.Random();

                a.Add(sv);
            }
            while (true)
            {
                Console.WriteLine("1:tim ten sinh vien trong danh sach ");
                Console.WriteLine("2:xoa danh sach ten sinh vien ");
                Console.WriteLine("3:them sinh vien ");
                Console.WriteLine("4:in danh sach ");
                int luaChon = int.Parse(Console.ReadLine());
                if (luaChon == 1)
                {
                    var b = TimTen(a);
                    if (b.Count < 1)
                        Console.WriteLine("khong co sinh vien nay ");
                    foreach (var item in b)
                    {
                        item.InManHinh();
                    }
                }
                if (luaChon == 2)
                {
                    Console.Write("nhap ten can xoa ");
                    var s = Console.ReadLine();
                    var b = XoaTen(a, s);
                    if (b.Count < 1)
                        Console.WriteLine("danh sch rong ");
                    foreach (var item in b)
                    {
                        item.InManHinh();
                    }
                }
                if (luaChon == 3)
                {
                    var b = ThemTen(a);
                    foreach (var item in b)
                    {
                        item.InManHinh();
                    }
                }
                if (luaChon == 4)
                {
                    foreach (var item in a)
                    {
                        item.InManHinh();
                    }
                }
            }

        }
    }

}