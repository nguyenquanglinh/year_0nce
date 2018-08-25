using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThiTrenForm
{

    abstract class ThuatToan : IThuatToan
    {
        protected IDoThi doThi;
        protected int[,] arr;

        public ThuatToan(IDoThi doThi)
        {
            this.doThi = doThi;
            Arr();
        }

        private void Arr()
        {
            arr = new int[doThi.SoDinhCuaDoThi, doThi.SoDinhCuaDoThi];
            foreach (var canh in doThi.TapCanh)
            {
                arr[int.Parse(canh.DiemDau.PointName), int.Parse(canh.DiemCuoi.PointName)] = arr[int.Parse(canh.DiemCuoi.PointName), int.Parse(canh.DiemDau.PointName)] = 1;
            }
        }

        protected bool KiemTraDuongDung(List<IDiem> tapDiem, int bd, int kt)
        {
            return tapDiem.Contains(doThi[bd.ToString()]) && tapDiem.Contains(doThi[kt.ToString()]);
        }

        public abstract List<IDiem> ThuTuDuyet(int viTriDuyet);
        public abstract Hinh TimDuongMin(int bd, int kt);
    }

    class DuyetBfs : ThuatToan
    {

        public DuyetBfs(IDoThi doThi)
            : base(doThi)
        {

        }

        override public List<IDiem> ThuTuDuyet(int dinh)
        {
            Hinh hinh = DuyetDinh(dinh);
            var result = new List<IDiem>();
            foreach (var diem in hinh.TapDinh)
            {
                result.Add(diem);
            }
            return result;
        }

        override public Hinh TimDuongMin(int bd, int kt)
        {
            var doThi = ThuTuDuyet(bd);
            if (!KiemTraDuongDung(doThi, bd, kt))
            {
                return null;
            }

            var dothi = DuyetDinh(bd);
            var pc = new PhanChung(dothi);
            var result = pc.TimDuong(bd, kt);
            return result;
        }


        private Hinh DuyetDinh(int dinh)
        {
            var dinhDaDuyet = new int[arr.GetLength(0)];
            var que = new Queue<int>();
            que.Enqueue(dinh);
            dinhDaDuyet[dinh] = -1;
            var result = new Hinh();
            while (que.Count != 0)
            {
                dinh = que.Dequeue();
                result.TapDinh.Add(doThi[dinh.ToString()]);
                for (int i = 0; i < arr.GetLength(0); i++)
                    if (arr[dinh, i] != 0 && dinhDaDuyet[i] == 0)
                    {
                        dinhDaDuyet[i] = 1;
                        result.TapCanh.Add(new Canh(doThi[i.ToString()], doThi[dinh.ToString()]));
                        que.Enqueue(i);
                    }
            }
            return result;
        }
    }

    class DuyetDfs : ThuatToan
    {

        public DuyetDfs(IDoThi doThi)
            : base(doThi)
        {

        }

        override public List<IDiem> ThuTuDuyet(int viTriDuyet)
        {
            var result = new List<IDiem>();
            var hinh = DuyetDinh(viTriDuyet);
            foreach (var item in hinh.TapDinh)
            {
                result.Add(item);
            }
            return result;
        }

        private Hinh DuyetDinh(int viTriDuyet)
        {
            var hinh = new Hinh();
            var dinhDaDuyet = new int[arr.GetLength(0)];
            var stack = new Stack<int>();
            stack.Push(viTriDuyet);

            dinhDaDuyet[viTriDuyet] = -1;
            while (stack.Count != 0)
            {
                viTriDuyet = stack.Pop();
                hinh.TapDinh.Add(doThi[viTriDuyet.ToString()]);
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[viTriDuyet, i] != 0 && dinhDaDuyet[i] == 0)
                    {
                        dinhDaDuyet[i] = -1;
                        stack.Push(i);
                        hinh.TapCanh.Add(new Canh(doThi[viTriDuyet.ToString()], doThi[i.ToString()]));
                    }
                }
            }
            return hinh;
        }


        override public Hinh TimDuongMin(int bd, int kt)
        {
            var doThi = ThuTuDuyet(bd);
            if (!KiemTraDuongDung(doThi, bd, kt))
                return null;
            var dothi = DuyetDinh(bd);
            var pc = new PhanChung(dothi);
            var result = pc.TimDuong(bd, kt);
            return result;
        }

    }

    class PhanChung
    {
        Hinh doThi;
        public PhanChung(Hinh hinh)
        {
            this.doThi = hinh;
        }
        //1

        #region Tim duong min

        private List<Canh> LayCacCanhKe(Hinh doThi, int ten, List<Canh> CacCanhKeTruocDo)
        {
            var CacCanhMoi = new List<Canh>();
            foreach (var canh in doThi.TapCanh)
                if (canh.CanhChung(ten))
                    if (!CacCanhKeTruocDo.Contains(canh))
                        CacCanhMoi.Add(canh);
            return CacCanhMoi;
        }

        //1.1
        private bool KiemTraDuongDung(List<IDiem> tapDiem, int bd, int kt)
        {
            return tapDiem.Contains(doThi[bd.ToString()]) && tapDiem.Contains(doThi[kt.ToString()]);
        }

        //2.1
        private void TimDuongDi(int bd, int kt, Hinh doThi, Hinh result, Hinh duongMin, List<Canh> cacCanhKe, List<int> dinhDaDuyet)
        {
            var cacCanhMoi = LayCacCanhKe(doThi, bd, cacCanhKe);
            var dinhTrungGian = new int[dinhDaDuyet.Count];
            dinhDaDuyet.CopyTo(dinhTrungGian);
            var dinhDuyet = dinhTrungGian.ToList();
            foreach (var item in cacCanhMoi)
            {
                var hinhMoi = new Hinh();
                int dinhMoi = item.LayDiemBenCuaCanh(bd);
                if (!duongMin.TapCanh.Contains(item))
                {
                    if (dinhDuyet.Contains(dinhMoi))
                        continue;
                    dinhDuyet.Add(bd);
                    CopyHinh(hinhMoi, duongMin);
                    hinhMoi.TapDinh.Add(doThi[bd.ToString()]);
                    hinhMoi.TapCanh.Add(item);
                    if (dinhMoi == kt)
                    {
                        hinhMoi.TapDinh.Add(doThi[kt.ToString()]);
                        if (result.TapDinh.Count == 0)
                            CopyHinh(result, hinhMoi);
                        else if (result.TapDinh.Count > hinhMoi.TapDinh.Count)
                        {
                            result = new Hinh();
                            CopyHinh(result, hinhMoi);
                        }
                        continue;
                    }
                    TimDuongDi(dinhMoi, kt, doThi, result, hinhMoi, cacCanhMoi, dinhDuyet);
                }
            }
        }

        //2.1.1
        private void CopyHinh(Hinh hinhMoi, Hinh duongMin)
        {
            foreach (var dinh in duongMin.TapDinh)
                hinhMoi.TapDinh.Add(dinh);
            foreach (var canh in duongMin.TapCanh)
                hinhMoi.TapCanh.Add(canh);
        }

        //2
        public Hinh TimDuong(int bd, int kt)
        {
            var result = new Hinh();
            TimDuongDi(bd, kt, doThi, result, new Hinh(), new List<Canh>(), new List<int>());
            return result;
        }

        #endregion

    }

}
