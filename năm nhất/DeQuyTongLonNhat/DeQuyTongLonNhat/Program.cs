using System;
using System.Collections.Generic;
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
        public List<List<Diem>> CacDuongDiTrongMang()
        {
            var ret = new List<List<Diem>>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (Arr[i, j] == 1)
                    {
                        var diem = new Diem(i, j);
                        var arr1 = Arr.Clone() as int[,];
                        arr = arr1;
                        tapDiemDaDuyet = new List<Diem>();
                        TimTheoDuongThang(diem);
                        if (tapDiemDaDuyet.Count > 1)
                            ret.Add(tapDiemDaDuyet);
                    }
                }
            }
            return ret;
        }

        public void TimTheoDuongThang(Diem diemBatDau)
        {
            tapDiemDaDuyet.Add(diemBatDau);
            var dTren = LayDiemBenTren(diemBatDau);
            if (dTren != null)
                TimTheoDuongThang(dTren);
            var dDuoi = LayDiemBenDuoi(diemBatDau);
            if (dDuoi != null)
                TimTheoDuongThang(dDuoi);
            var dTrai = LayDiemBenTrai(diemBatDau);
            if (dTrai != null)
                TimTheoDuongThang(dTrai);
            var dPhai = LayDiemBenPhai(diemBatDau);
            if (dPhai != null)
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

    }

    class Program
    {


        static void Main(string[] args)
        {
            var arr = new int[5, 5] { { 0, 0, 0, 0, 1 }, { 0, 1, 0, 1, 0 }, { 0, 0, 1, 0, 1 }, { 0, 1, 0, 1, 1 }, { 0, 0, 1, 1, 0 } };
            var s = new TongMax(arr);
            var diem = new Diem(4, 2);
            //  s.XuatArr();
            s.TimTheoDuongThang(diem);
            
            var sssssssss = s.CacDuongDiTrongMang();
            s.XuatArr();
            Console.ReadKey();
        }
    }
}
