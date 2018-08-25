using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace TimDuongTrenForm
{
    class DuyetDfs
    {
        DoThi dt;

        public DuyetDfs(DoThi dT)
        {
            dt = dT;
        }

        int[,] Arr()
        {
            int[,] arr = new int[dt.tapDinh.Count, dt.tapDinh.Count];
            foreach (var canh in dt.tapCanh)
            {
                arr[int.Parse(canh.DiemDau.NameHt), int.Parse(canh.DiemCuoi.NameHt)] = arr[int.Parse(canh.DiemCuoi.NameHt), int.Parse(canh.DiemDau.NameHt)] = 1;
            }
            return arr;
        }

        List<Hinh> DemDoThi()
        {
            var soDothi = new List<Hinh>();
            var cacDinhDangDuyet = ThuTuDinhDuyet(0);
            if (cacDinhDangDuyet.tapDinh[0] != null)
                soDothi.Add(cacDinhDangDuyet);
            var sss = dt.tapDinh.Count;
            for (int i = 1; i < dt.tapDinh.Count; i++)
            {
                if (!KiemTraDinhDaDuyet(soDothi, i))
                {
                    cacDinhDangDuyet = ThuTuDinhDuyet(i);
                    if (cacDinhDangDuyet.tapDinh[0] != null)
                        soDothi.Add(cacDinhDangDuyet);
                }
            }

            return soDothi;
        }

        private bool KiemTraDinhDaDuyet(List<Hinh> soDothi, int i)
        {
            foreach (var hinh in soDothi)
                foreach (var Dinh in hinh.tapDinh)
                    if (Dinh.NameHt == i.ToString())
                        return true;
            return false;
        }

        private Hinh ThuTuDinhDuyet(int p)
        {
            var hinh = new Hinh();
            var dinhDaDuyet = new int[dt.tapDinh.Count];
            DuyetDinh(p, hinh, dinhDaDuyet);
            return hinh;
        }

        public void CacDinhDuyet(int dinh)
        {
            var hinh = ThuTuDinhDuyet(dinh);
            var color = LayMau();
            foreach (var item in hinh.tapDinh)
            {
                item.Color = color;
                MessageBox.Show(item.NameHt.ToString());
            }
        }

        private void DuyetDinh(int p, Hinh hinh, int[] dinhDaDuyet)
        {
            var dD = dt.LayHinhTron(p);
            hinh.tapDinh.Add(dD);
            dinhDaDuyet[p] = -1;
            var arr = Arr();
            for (int i = 0; i < dt.tapDinh.Count; i++)
            {
                if (arr[p, i] == 1)
                {
                    var canh = new Canh(dt.LayHinhTron(i), dD);
                    if (!hinh.tapCanh.Contains(canh))
                        hinh.tapCanh.Add(canh);
                    if (dinhDaDuyet[i] == 0)
                        DuyetDinh(i, hinh, dinhDaDuyet);
                }
            }
        }

        Color LayMau()
        {
            Random rd = new Random();
            var list = new List<Color>();
            list.Add(Color.Blue);
            list.Add(Color.Red);
            list.Add(Color.PeachPuff);
            list.Add(Color.Pink);
            list.Add(Color.Purple);
            list.Add(Color.PowderBlue);
            list.Add(Color.BurlyWood);
            return list[rd.Next(0, list.Count)];
        }

        public void ToMau()
        {
            if (dt.tapDinh.Count == 0)
            {
                MessageBox.Show("file chưa được đọc cần đọc file");
                return;
            }
            var soDoThi = DemDoThi();
            ToMauCacDoThi(soDoThi);
        }

        private void ToMauCacDoThi(List<Hinh> soDoThi)
        {
            foreach (var item in soDoThi)
            {
                var color = LayMau();
                VeDoThi1DoThi(item, color);
            }
        }

        private void VeDoThi1DoThi(Hinh item, Color color)
        {
            foreach (var i in item.tapCanh)
            {
                i.DiemCuoi.Color = color;
                dt.VeCanh(i);
            }
            if (item.tapDinh.Count > 1)
                foreach (var dinh in item.tapDinh)
                    dinh.Color = color;
        }


        internal void TimDuongMin(int bd, int kt)
        {
            var dothi = DoThiChuaDiemBatDauVaKetThuc(bd, kt);
            var cacLoaiDuongDi = new List<Hinh>();
            LayDuongDi(bd, kt, dothi, cacLoaiDuongDi, new Hinh(), new List<Canh>(), new List<int>());
            if (cacLoaiDuongDi.Count == 0)
            {
                MessageBox.Show("không có đường");
                return;
            }
            var duongMin = cacLoaiDuongDi[0];
            foreach (var duong in cacLoaiDuongDi)
            {
                if (duongMin.tapCanh.Count >= duong.tapCanh.Count)
                    duongMin = duong;
            }
            VeDoThi1DoThi(duongMin, LayMau());
            MessageBox.Show("đã tô màu đường đi từ" + bd.ToString() + "đến" + kt.ToString());
        }

        private Hinh DoThiChuaDiemBatDauVaKetThuc(int bd, int kt)
        {
            var hinh = DemDoThi();
            var ret = new Hinh();
            var color = LayMau();
            foreach (var item in hinh)
            {
                if (CoDiemBatVaketThu(item, bd) && CoDiemBatVaketThu(item, kt))
                {
                    VeDoThi1DoThi(item, color);
                    ret = item;
                }
            }
            return ret;
        }

        void LayDuongDi(int bd, int kt, Hinh dothi, List<Hinh> tapDuongDi, Hinh duongMin, List<Canh> cacCanhKe, List<int> dinhDaDuyet)
        {
            var cacCanhKeDinhMoi = LayCanhTuHinh(dothi, bd, cacCanhKe);
            var dinhDuyet = DinhDaDuyet(dinhDaDuyet);
            foreach (var item in cacCanhKeDinhMoi)
            {
                var hinhMoi = new Hinh();
                int dinhMoi = LayTenDinh(item, bd);
                if (!duongMin.tapCanh.Contains(item))
                {
                    if (DinhDaDuocDuyet(dinhMoi, dinhDuyet))
                        continue;
                    dinhDuyet.Add(bd);
                    foreach (var dinh in duongMin.tapDinh)
                        hinhMoi.tapDinh.Add(dinh);
                    foreach (var canh in duongMin.tapCanh)
                        hinhMoi.tapCanh.Add(canh);
                    hinhMoi.tapDinh.Add(dt.LayHinhTron(bd));
                    hinhMoi.tapCanh.Add(item);
                    if (dinhMoi == kt)
                    {
                        hinhMoi.tapDinh.Add(dt.LayHinhTron(kt));
                        tapDuongDi.Add(hinhMoi);
                        continue;
                    }
                    LayDuongDi(dinhMoi, kt, dothi, tapDuongDi, hinhMoi, cacCanhKeDinhMoi, dinhDuyet);
                }
            }
        }

        private int LayTenDinh(Canh canh, int bd)
        {
            if (canh.DiemDau.NameHt == bd.ToString())
                return int.Parse(canh.DiemCuoi.NameHt);
            return int.Parse(canh.DiemDau.NameHt);
        }

        private bool DinhDaDuocDuyet(int dinhMoi, List<int> dinhDaDuyet)
        {
            foreach (var item in dinhDaDuyet)
            {
                if (item == dinhMoi)
                    return true;
            }
            return false;
        }
        //1
        private List<Canh> LayCanhTuHinh(Hinh dothi, int ten, List<Canh> cacCanhKe)
        {
            var cacCanhKeDinhMoi = new List<Canh>();
            foreach (var item in dothi.tapCanh)
                if (item.DiemDau.NameHt == ten.ToString() || item.DiemCuoi.NameHt == ten.ToString())
                {
                    var canh = item;
                    if (!cacCanhKe.Contains(canh))
                        cacCanhKeDinhMoi.Add(canh);
                }
            return cacCanhKeDinhMoi;
        }

        private List<int> DinhDaDuyet(List<int> dinhDaDuyet)
        {
            var dinhDaDuyetMoi = new List<int>();
            foreach (var item in dinhDaDuyet)
            {
                dinhDaDuyetMoi.Add(item);
            }
            return dinhDaDuyetMoi;
        }

        private bool CoDiemBatVaketThu(Hinh dothi, int bd)
        {
            if (dothi.tapDinh.Count < 2)
                return false;

            foreach (var item in dothi.tapDinh)
                if (item.NameHt == bd.ToString())
                    return true;
            return false;
        }
    }
}
