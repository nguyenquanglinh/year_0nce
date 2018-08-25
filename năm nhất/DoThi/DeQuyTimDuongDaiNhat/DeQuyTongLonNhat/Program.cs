using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQuyTongLonNhat
{
    class TongMax
    {
        public List<Diem> tapDiemDaDuyet = new List<Diem>();
        int[,] arr;
        public int[,] Arr { get; set; }

        public TongMax(int[,] arr1)
        {
            Arr = arr1;
            arr = arr1.Clone() as int[,];
        }

        public void XuatArr()
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public List<Diem> DuongDiDaiNhatTrongMang()
        {
            var ret = new List<List<Diem>>();
            var arr1 = Arr.Clone() as int[,];
            arr = arr1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (Arr[i, j] == 1)
                    {
                        var diem = new Diem(i, j);
                        tapDiemDaDuyet = new List<Diem>();
                        TimTheoDuongThang(diem);
                        if (tapDiemDaDuyet.Count > 1)
                            ret.Add(tapDiemDaDuyet);
                    }
                }
            }
            var max = new List<Diem>();
            foreach (var item in ret)
            {
                if (item.Count > max.Count)
                    max = item ;
            }
            return max;
        }

        public void TimTheoDuongThang(Diem diemBatDau)
        {
            if (arr[diemBatDau.Ox, diemBatDau.Oy] == 0)
                return;
            tapDiemDaDuyet.Add(diemBatDau);
            var dTren = LayDiemBenTren(diemBatDau);
            var dDuoi = LayDiemBenDuoi(diemBatDau);
            var dTrai = LayDiemBenTrai(diemBatDau);
            var dPhai = LayDiemBenPhai(diemBatDau);
            if (dTren != null)
                TimTheoDuongThang(dTren);
            else if (dDuoi != null)
                TimTheoDuongThang(dDuoi);
            else if (dTrai != null)
                TimTheoDuongThang(dTrai);

            else if (dPhai != null)
                TimTheoDuongThang(dPhai);

        }

        #region LayDiemTrenDuoiTraiPhai

        private Diem LayDiemBenTren(Diem diem)
        {

            if (diem.Ox == Arr.GetLength(0) - 1)
                return null;
            else if (arr[diem.Ox + 1, diem.Oy] == 1)
            {
                arr[diem.Ox, diem.Oy] = 0;
                var ret = new Diem(diem.Ox + 1, diem.Oy);
                return ret;
            }
            return null;
        }

        private Diem LayDiemBenDuoi(Diem diem)
        {
            if (diem.Ox == 0)
                return null;
            else if (arr[diem.Ox - 1, diem.Oy] == 1)
            {
                arr[diem.Ox, diem.Oy] = 0;
                var ret = new Diem(diem.Ox - 1, diem.Oy);
                return ret;
            }
            return null;
        }

        private Diem LayDiemBenPhai(Diem diem)
        {

            if (diem.Oy == Arr.GetLength(1) - 1)
                return null;
            else if (arr[diem.Ox, diem.Oy + 1] == 1)
            {
                arr[diem.Ox, diem.Oy] = 0;
                var ret = new Diem(diem.Ox, diem.Oy + 1);
                return ret;
            }
            return null;
        }

        private Diem LayDiemBenTrai(Diem diem)
        {
            if (diem.Oy == 0)
                return null;
            else if (arr[diem.Ox, diem.Oy - 1] == 1)
            {
                arr[diem.Ox, diem.Oy] = 0;
                var ret = new Diem(diem.Ox, diem.Oy - 1);
                return ret;
            }
            return null;
        }

        #endregion

    }
    class Diem
    {
        public int Ox { get; set; }
        public int Oy { get; set; }
        public Diem(int oX, int oY)
        {
            Ox = oX;
            Oy = oY;
        }
        public override string ToString()
        {
            return "[" + this.Ox.ToString() + "," + this.Oy.ToString() + "]";
        }
    }

    class Program
    {
        static int[,] DocFile(string tenFile)
        {
            string path1 = "D:\\" + tenFile;
            FileStream fs = new FileStream(path1, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);

            string dong = rd.ReadLine();
            var xx = dong.Split(',');
            int hang = 0;
            var arr = new int[int.Parse(xx[0]), int.Parse(xx[1])];
            while (true)
            {
                dong = rd.ReadLine();
                if (dong == null)
                    break;
                xx = dong.Split(',');
                if (hang >= arr.GetLength(0))
                    throw new Exception("lỗi");
                for (int i = 0; i < xx.Length; i++)
                {
                    arr[hang, i] = int.Parse(xx[i]);
                }
                hang++;

            }

            rd.Close();
            return arr;
        }

        static void GhiFile(string tenFile, List<Diem> list)
        {
            string path = "D:\\" + tenFile;
            var s = "";
            foreach (var item in list)
            {
                s = s + item + "=>";
            }
            if (list.Count > 0)
                s = s.Remove(s.Length - 2, 2);
            string appendText = s + Environment.NewLine;
            File.AppendAllText(path, appendText);
        }

        static Diem LayDiemNgauNhien(int[,] arr)
        {
            var rd = new Random();
            var list = new List<Diem>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        var diem = new Diem(i, j);
                        list.Add(diem);
                    }
                }
            }
            if (list.Count == 0)
                return null;
            return list[rd.Next(0, list.Count)];
        }
        static void Main(string[] args)
        {
            var arr = DocFile("arr4.txt");
            var tongMax = new TongMax(arr);
            tongMax.XuatArr();
            var diem = new Diem(0, 0);

            tongMax.TimTheoDuongThang(diem);

            var sss = tongMax.DuongDiDaiNhatTrongMang();
           
            GhiFile("a.txt", sss);
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}

