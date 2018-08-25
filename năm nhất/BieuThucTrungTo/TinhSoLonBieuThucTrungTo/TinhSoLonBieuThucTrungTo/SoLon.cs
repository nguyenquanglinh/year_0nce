using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhSoLonBieuThucTrungTo
{
    public class SoLon
    {
        int[] arr;
        string chuoi;
        bool LaSoAm { get; set; }
        //hàm tạo chuỗi
        public SoLon(string s)
        {
            if (s != "" && s[0] == '-')
            {
                LaSoAm = true;
                s = s.Remove(0, 1);
            }
            arr = TaoArr(s);
            s = XoaCacSo0DauTien;
            arr = TaoArr(s);

        }

        //ham tao mang
        public SoLon(int[] a)
        {
            arr = a;
            var s = XoaCacSo0DauTien;
            arr = TaoArr(s);
            if (a.Length > 0 && arr[0] < 0)
            {
                arr[0] = Math.Abs(arr[0]);
                LaSoAm = true;
            }
        }

        //hàm xoa các số 0 ở đầu
        string XoaCacSo0DauTien
        {
            get
            {
                if (arr.Length == 0)
                    return "0";
                bool gapSoKhac0 = false;
                string s = "";
                foreach (var item in arr)
                {
                    if (item == 0 && gapSoKhac0 == false)
                        continue;
                    else
                    {
                        gapSoKhac0 = true;
                        s += item;
                    }
                }

                return s;
            }
        }

        //tạo arr
        int[] TaoArr(string s)
        {
            arr = new int[s.Length];
            if (s.Length < 1)
                arr = new int[1];
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]))
                    arr[i] = int.Parse(s[i].ToString());
            }
            return arr;
        }

        //overideto string
        public override string ToString()
        {
            var s = "";
            if (LaSoAm)
                s = "-";
            foreach (var item in arr)
            {
                s += item;
            }
            if (s == "-")
                return "0";
            return s;
        }
        //hàm equals
        public override bool Equals(object obj)
        {
            var a = obj as SoLon;
            return a != null && a.ToString() == ToString();
        }
        //cộng
        SoLon Cong(SoLon b)
        {
            if (ToString() == "0")
                return b;
            if (b.ToString() == "0")
                return this;
            var max = Math.Max(this.arr.Length, b.arr.Length);
            if (this.arr.Length < max)
                this.arr = MakeSameLength(arr, max);
            if (b.arr.Length < max)
                b.arr = MakeSameLength(b.arr, max);
            var ret = new int[max + 1];
            int nho = 0;
            for (int i = max - 1; i >= 0; i--)
            {
                var tong = arr[i] + b.arr[i];
                if (nho != 0)
                {
                    tong++;
                    nho = 0;
                }
                if (tong > 9)
                {
                    nho = 1;
                    tong -= 10;
                }
                ret[i + 1] = tong;
            }
            if (nho != 0)
                ret[0] = nho;
            return new SoLon(ret);
        }
        //trừ
        SoLon Tru(SoLon b)
        {
            if (b.ToString() == "0")
                return this;
            else if (ToString() == "0")
                return b;
            var max = Math.Max(arr.Length, b.arr.Length);
            if (arr.Length < max)
                arr = MakeSameLength(arr, max);
            if (b.arr.Length < max)
                b.arr = MakeSameLength(b.arr, max);
            var nho = 0;
            var ret = new int[max];
            for (int i = max - 1; i >= 0; i--)
            {
                var hieu = arr[i] - b.arr[i];
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
            if (nho != 0)
                ret[0] = ret[0] - nho;
            return new SoLon(ret);

        }
        //+
        public static SoLon operator +(SoLon a, SoLon b)
        {
            //a la so am b la so am
            if (a.LaSoAm && b.LaSoAm)
            {
                var ret = a.Cong(b);
                ret.LaSoAm = true;
                return ret;
            }
            //a duong b duong
            else if (a.LaSoAm == false && b.LaSoAm == false)
            {
                var ret = a.Cong(b);
                ret.LaSoAm = false;
                return ret;
            }
            //a là âm b la duong
            else
            {
                var ret = a.Tru(b);
                if (a.Compareto(b) == -1)
                {
                    ret.LaSoAm = false;
                }
                else
                {
                    ret.LaSoAm = true;
                }

                return ret;
            }
        }
        // so sanh
        public int Compareto(SoLon b)
        {
            var ar = this.arr;
            var br = b.arr;
            if (ar.Length > br.Length)
                return 1;
            else if (ar.Length < br.Length)
                return -1;
            else if (ar.Length == br.Length)
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] > br[i])
                        return 1;
                    if (ar[i] < br[i])
                        return -1;
                }
            }
            return 0;
        }
        //tạo mảng có độ dài sẵn
        static int[] MakeSameLength(int[] a, int length)
        {
            var x = new int[length];
            for (int i = 0; i < a.Length; i++)
            {
                x[i + length - a.Length] = a[i];
            }
            return x;
        }
 
    }

}



