using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BieuThucTrungToSoLonConsole
{
    public class SoLon
    {
        string chuoi;
        public int[] arr;
        public int[] MangCoban
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
            }
        }
        // ham tao chuoi
        public SoLon(string s)
        {

            if (s != "" && s[0] == '-')
            {
                LasoAm = true;
                s = s.Remove(0, 1);
            }
            arr = new int[s.Length];
            if (s.Length < 1)
                arr = new int[1];
          
            for (int i = 0; i < s.Length; i++)
            {
                //can kt toan tu
                if (Char.IsNumber(s[i]))
                    arr[i] = int.Parse(s[s.Length - 1 - i].ToString());
                if (!Char.IsNumber(s[i]) && i > 0)
                    throw new ArgumentException("đây là biểu thức sai");
            }
            arr = arr.Reverse().ToArray();
        }

        //ham tao mang
        public SoLon(int[] a)
        {
            arr = a;
            if (a.Length > 0 && arr[0] < 0)
            {
                arr[0] = Math.Abs(arr[0]);
                LasoAm = true;
            }
        }

        //ham so sanh
        public override bool Equals(object obj)
        {
            var a = obj as SoLon;
            return a != null && a.ToString() == ToString();
        }

        //chưa biết dùng
        public override int GetHashCode()
        {
            return chuoi.GetHashCode();
        }

        //ham in tra ve kq
        public override string ToString()
        {
            if (arr.Length == 0)
                return "0";
            bool gapSOKhac0 = false;
            string s = "";
            if (LasoAm == true)
                s = "-";
            int dem = 0;
            foreach (var item in arr)
            {
                if (item == 0 && gapSOKhac0 == false)
                {
                    dem++;
                    continue;
                }
                else
                {
                    gapSOKhac0 = true;
                    s = s + item;
                }
            }
            if (s.Length == 0)
                return "0";
            if (dem == arr.Length)
                return "0";
            return s;
        }

        //kiem tra so am duong
        public bool LasoAm { get; set; }

        //cong 2 mang
        static int[] CongMang(int[] a, int[] b)
        {
            var max = Math.Max(a.Length, b.Length);

            if (a.Length < max)
                a = MakeSameLength(a, max);

            if (b.Length < max)
                b = MakeSameLength(b, max);
            var nho = 0;
            var ret = new int[max];
            if (a[0] + b[0] > 9)
                ret = new int[max + 1];
            int i = 0;
            for (i = max - 1; i >= 0; i--)
            {
                var tong = a[i] + b[i];
                if (nho == 1)
                {
                    tong = tong + 1;
                    nho = 0;
                }
                if (tong > 9)
                {
                    nho = 1;
                    tong -= 10;
                }
                ret[i] = tong;
            }
            if (nho != 0 && i + 1 > 0)
                ret[i + 1] = nho;
            if (max == 1 && ret.Length == 2)
            {
                ret[1] = nho;
                ret = ret.Reverse().ToArray();
            }
            return ret;
        }

        //phep cong 
        static SoLon Cong(SoLon a, SoLon b)
        {
            if (a.ToString() == "0")
                return b;
            if (b.ToString() == "0")
                return a;
            var ret = CongMang(a.arr, b.arr);
            return new SoLon(ret);
        }

        //phep +
        public static SoLon operator +(SoLon a, SoLon b)
        {
            //a la so am b la so am
            if (a.LasoAm && b.LasoAm)
            {
                var ret = Cong(a, b);
                ret.LasoAm = true;
                return ret;
            }
            //a duong b duong
            else if (a.LasoAm == false && b.LasoAm == false)
            {
                var ret = Cong(a, b);
                ret.LasoAm = false;
                return ret;
            }
            //a là âm b la duong
            else
            {
                var ret = Tru(a, b);
                if (a.Compareto(b) == -1)
                {
                    ret.LasoAm = false;
                }
                else
                {
                    ret.LasoAm = true;
                }

                return ret;
            }
        }

        // tru mang
        static int[] TruMang(int[] a, int[] b)
        {
            var max = Math.Max(a.Length, b.Length);
            if (a.Length < max)
                a = MakeSameLength(a, max);
            if (b.Length < max)
                b = MakeSameLength(b, max);
            var nho = 0;
            var ret = new int[a.Length];
            //a nho hon b
            for (int i = max - 1; i >= 0; i--)
            {
                var hieu = a[i] - b[i];
                if (nho == 1)
                {
                    hieu -= 1;
                    nho = 0;
                }
                if (hieu < 0)
                {
                    hieu += 10;
                    nho = 1;
                }
                ret[i] = hieu;
            }
            return ret;
        }

        //phep tru 
        static SoLon Tru(SoLon a, SoLon b)
        {
            if (b.ToString() == "0")
                return a;
            else if (a.ToString() == "0")
                return b;
            var max = Math.Max(a.arr.Length, b.arr.Length);


            var mangLon = MakeSameLength(a.arr, max);
            var mangNho = MakeSameLength(b.arr, max);
            if (a.Compareto(b) == -1)
            {
                mangLon = b.arr;
                mangNho = a.arr;
            }
            var ret = TruMang(mangLon, mangNho);
            return new SoLon(ret);
        }

        // phep -
        public static SoLon operator -(SoLon a, SoLon b)
        {
            //a duong b duong
            if (a.LasoAm == false && b.LasoAm == false)
            {
                var ret = Tru(a, b);
                ret.LasoAm = false;
                //a nho hon b thi am
                if (a.Compareto(b) == -1)
                    ret.LasoAm = true;
                return ret;
            }//a am b am
            else if (a.LasoAm && b.LasoAm)
            {
                var ret = Tru(a, b);
                if (a.Compareto(b) == -1)//a<b am
                    ret.LasoAm = false;
                else
                    ret.LasoAm = true;//nguoc lai la duong
                return ret;
            }
            //a duong b am
            else if (a.LasoAm == false && b.LasoAm)
            {
                var ret = Cong(a, b);
                ret.LasoAm = false;
                return ret;
            }
            //a am b duong
            else
            {
                var ret = Tru(a, b);
                ret.LasoAm = true;
                return null;
            }
        }

        //phep gia thừa
        public SoLon GiaiThua()
        {
            var a = this;
            var ret = new SoLon("1");
            while (!a.Equals(new SoLon("1")))
            {
                ret = ret * a;
                a = a - new SoLon("1");
            }
            return ret;
        }

        //chưa làm được
        public static SoLon operator !(SoLon a)
        {
            if (a.LasoAm)
                return null;
            return a.GiaiThua(); 
        }

        //phep mu
        static SoLon Mu(SoLon a, SoLon mu)
        {
            var ret = new SoLon("1");
            var donVi = new SoLon("1");
            var dem = new SoLon("0");
            while (!dem.Equals(mu))
            {
                ret = ret * a;
                dem = dem + donVi;
            }
            return ret;
        }

        //phep ^
        public static SoLon operator ^(SoLon a, SoLon mu)
        {
            return Mu(a, mu);
        }

        //so do dai ,gia tri cua tung phan tu trong mang
        public int Compareto(SoLon b)
        {
            var ar = this.arr;
            var br = b.arr;
            if (ar.Length > br.Length)
                return 1;
            else if (ar.Length < br.Length)
                return -1;
            else  
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] > br[i])
                        return 1;
                    if (ar[i] < br[i])
                        return -1;
                }
                return 0;
            } 
        }

        //tao do dai mang = nhau
        static int[] MakeSameLength(int[] a, int length)
        {
            var x = new int[length];
            for (int i = 0; i < a.Length; i++)
            {
                x[i + length - a.Length] = a[i];
            }
            return x;
        }
        
        // them 1 so khong vao mang==*10
        static int[] Them10DonViChoSo(int[] a, int donVi)
        {
            var x = new int[a.Length + donVi];
            for (int i = 0; i < a.Length; i++)
            {
                x[i] = a[i];
            }
            return x;
        }

        //nhan 1 so voi 1 mang
        static int[] NhanSoVoiMang(int x, int[] a)
        {
            var thuong = 0;
            var kq = new int[a.Length];
            if (a[0] * x > 9)
                kq = new int[a.Length + 1];
            var tich = 0;
            int i = 0;
            for (i = 0; i < a.Length; i++)
            {
                tich = x * a[a.Length - i - 1];
                if (thuong != 0)
                {
                    tich = tich + thuong;
                    thuong = 0;
                }
                if (tich > 9)
                {
                    thuong = tich / 10;
                    tich = tich % 10;
                }
                kq[i] = tich;
            }
            if (i - 1 < kq.Length - 1)
                kq[i] = thuong;
            else if (thuong != 0)
            {
                kq = Them10DonViChoSo(kq, 1);
                kq[kq.Length - 1] = thuong;
            }
            return kq.Reverse().ToArray();
        }

        // phep nhan
        static SoLon Nhan(SoLon a, SoLon b)
        {
            var mangLon = a.arr;
            var mangNho = KiemTraMangKhac0(b.arr);
            if (a.Compareto(b) == -1)
            {
                mangLon = b.arr;
                mangNho = KiemTraMangKhac0(a.arr);
            }
            var ret = new int[mangNho.Length];
            for (int i = 0; i < mangNho.Length; i++)
            {
                var x = NhanSoVoiMang(mangNho[mangNho.Length - 1 - i], mangLon);
                if (i > 0)
                    x = Them10DonViChoSo(x, i);
                ret = CongMang(x, ret);
            }

            return new SoLon(ret.ToArray());
        }
        static int[] KiemTraMangKhac0(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    break;
                }
                dem++;
            }
            var x = new int[a.Length - dem];
            for (int i = dem; i < a.Length; i++)
            {

                x[i - dem] = a[i];
            }
            return x;
        }

        // phep *
        public static SoLon operator *(SoLon a, SoLon b)
        {
            var ret = Nhan(a, b);
            if (a.LasoAm && b.LasoAm)
                ret.LasoAm = false;
            else if (a.LasoAm == false && b.LasoAm == false)
                ret.LasoAm = false;
            else ret.LasoAm = true;
            return ret;
        }


    }
}
