using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeDoThiLienThong
{

    public class Hinh
    {
        public Hinh()
        {
            tapDinh = new List<HinhTron>();
            tapCanh = new List<Canh>();
        }
        public List<HinhTron> tapDinh;
        public List<Canh> tapCanh;
    }

    public class DoThi
    {
        #region biến toàn cục
        Form form;
        List<HinhTron> tapDinhDt;
        List<Canh> tapCanh;

        public List<string> tenDinh()
        {
            var tenDinh = new List<string>();
            foreach (var item in tapDinhDt)
            {
                tenDinh.Add(item.Ten);
            }
            return tenDinh;
        }
        int[,] arr;

        HinhTron lastedClick = null;

        #endregion

        #region hàm tạo vẽ

        // 1 hàm tạo đồ thị từ form
        public DoThi(Form f1)
        {
            form = f1;
            tapCanh = new List<Canh>();
            tapDinhDt = new List<HinhTron>();
            f1.Paint += f1_Paint;
        }

        

        //kiem tra hinh tron da co
        bool OverLapHt(HinhTron ht)
        {
            foreach (var item in this.tapDinhDt)
                if (ht.Overlap(item))
                    return true;
            return false;
        }

        //vẽ hình tròn bằng tọa độ x,y
        public void ThemDinh(int x, int y)
        {
            var ht = VeHinhTron(x, y);
            //....
            if (OverLapHt(ht))
                return;
            if (!tapDinhDt.Contains(ht))
            {
                tapDinhDt.Add(ht);
                NewArr();
                form.Controls.Add(ht);
            }
            ht.Click += a_Click;
            ht.DoubleClick += ht_DoubleClick;
            GhiTenDinhLenHinhTron();

        }

        void NewArr()
        {
            arr = new int[tapDinhDt.Count, tapDinhDt.Count];
            foreach (var item in tapCanh)
            {
                arr[int.Parse(item.DiemDau.Ten), int.Parse(item.DiemCuoi.Ten)] = arr[int.Parse(item.DiemCuoi.Ten), int.Parse(item.DiemDau.Ten)] = 1;
            }
        }

        //thêm cạnh vào tập cạnh từ ht a ht b
        public void ThemCanh(Canh canh)
        {


            if (!tapCanh.Contains(canh))
            {
                tapCanh.Add(canh);
                NewArr();
                canh.DiemDau.Color = Color.Blue;
                canh.DiemCuoi.Color = Color.Blue;
            }
            else
            {
                canh.DiemCuoi.Color = Color.Blue;
                canh.DiemDau.Color = Color.Blue;
            }

            form.Invalidate();
        }

        //vẽ ht trên form liên tục
        public void Draw()
        {
            GhiTenDinhLenHinhTron();

            foreach (var item in tapCanh)
            {
                VeCanh(item);
            }
        }
        //hàm vẽ
        void f1_Paint(object sender, PaintEventArgs e)
        {
            this.Draw();
        }
        #endregion

        #region vẽ hình cạnh thêm đỉnh

        int demDinh;
        void GhiTenDinhLenHinhTron()
        {
            demDinh = 0;
            foreach (var ht in tapDinhDt)
            {
                ht.Ten = demDinh.ToString();
                demDinh++;
            }
        }

        //vẽ hình tròn =ht truyền vào
        HinhTron VeHinhTron(int x, int y)
        {
            var ht = new HinhTron() { Location = new Point(x, y) };
            ht.Color = Color.Blue;
            return ht;
        }

        //xóa hình tròn khi double.click
        void ht_DoubleClick(object sender, EventArgs e)
        {
            demDinh--;
            var ht = sender as HinhTron;
            for (int i = 0; i < tapDinhDt.Count; i++)
            {
                if (ht.Equals(tapDinhDt[i]))
                {
                    tapDinhDt.RemoveAt(i);
                }
            }
            XoaCanh(ht);
            lastedClick = null;
            form.Controls.Remove(ht);
            form.Invalidate();
        }

        //xóa cạnh của hình tròn khi xóa 1 đỉnh của hình tròn
        void XoaCanh(HinhTron a)
        {
            for (int i = tapCanh.Count - 1; i >= 0; i--)
            {
                var dDau = tapCanh[i].DiemDau;
                var dCuoi = tapCanh[i].DiemCuoi;
                if (tapCanh[i].DiemDau.Equals(a) || tapCanh[i].DiemCuoi.Equals(a))
                {
                    tapCanh.RemoveAt(i);
                }
            }
        }

        //vẽ hình tròn từ sự kiện click
        void a_Click(object sender, EventArgs e)
        {
            var ht = sender as HinhTron;
            ht.Color = Color.Red;

            if (lastedClick == null)
            {
                lastedClick = ht;
                return;
            }
            if (ht.Equals(lastedClick))
                return;
            var canh = new Canh(lastedClick, ht);
            ThemCanh(canh);
            lastedClick = null;
        }

        //vẽ cạnh trong tập cạnh
        private void VeCanh(Canh canh)
        {
            var dDau = canh.DiemDau;
            var dCuoi = canh.DiemCuoi;
            var color = dCuoi.Color;

            using (Graphics g = form.CreateGraphics())
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen p = new Pen(color, 2))
                {
                    g.DrawLine(p, dDau.Center, dCuoi.Center);
                }
            }

        }

        #endregion

        #region dfs

        private bool DinhDaDuocDuyet(List<int> a, int dinh)
        {
            if (a == null)
                return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == dinh)
                    return true;
            }
            return false;
        }

        internal List<Hinh> DemDoThi()
        {
            //kiểm tra có bao nhiêu đồ thị liên thông
            var soDothi = new List<Hinh>();

            var caDinhDangDuyet = ThuTuDinhDuyet(0);
            if (caDinhDangDuyet.tapDinh[0] != null)
                soDothi.Add(caDinhDangDuyet);
            var sss = arr.GetLength(0);
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                if (!KiemTraDinhDaDuyet(soDothi, i))
                {
                    caDinhDangDuyet = ThuTuDinhDuyet(i);
                    if (caDinhDangDuyet.tapDinh[0] != null)
                        soDothi.Add(caDinhDangDuyet);
                }
            }
            return soDothi;
            //trả về số đồ  thị liên thông

        }

        bool KiemTraDinhDaDuyet(List<Hinh> listHinh, int DinhCanKiemTra)
        {
            foreach (var hinh in listHinh)
                foreach (var Dinh in hinh.tapDinh)
                    if (Dinh.Ten == DinhCanKiemTra.ToString())
                        return true;
            return false;
        }

        public Hinh ThuTuDinhDuyet(int dinhDuyet)
        {
            var hinh = new Hinh();
            var dinhDaDuyet = new int[arr.GetLength(0)];
            DuyetDinh(dinhDuyet, hinh, dinhDaDuyet);
            return hinh;
        }

        public void DuyetDinh(int dinh, Hinh hinh, int[] dinhDaDuyet)
        {
            var dD = LayHinhTron(dinh);
            hinh.tapDinh.Add(dD);
            dinhDaDuyet[dinh] = -1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[dinh, i] == 1)
                {
                    var dCuoi = LayHinhTron(i);
                    var canh = new Canh(dD, dCuoi);
                    if (!hinh.tapCanh.Contains(canh))
                        hinh.tapCanh.Add(new Canh(dD, dCuoi));
                    if (dinhDaDuyet[i] == 0)
                        DuyetDinh(i, hinh, dinhDaDuyet);
                }

            }
        }
        #endregion

        #region LuuFile LayFile

        //ghi lại các đỉnh
        void LuuDinhVaoFile()
        {
            if (tapDinhDt.Count > 0)
            {
                string path = "D:\\FileDinh.txt";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                foreach (var item in tapDinhDt)
                {
                    var x = item.Center.X;
                    var y = item.Center.Y;
                    var s = x + ";" + y;
                    string appendText = s + Environment.NewLine;
                    File.AppendAllText(path, appendText);
                }
                MessageBox.Show("Đã lưu đồ thị trên form");
            }
            else
                MessageBox.Show("trên form không có đồ thị");
        }

        //  thêm cạnh từ file vào tập cạnh
        private void VeLaiCanh()
        {
            string path = "D:\\FileArr.txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("file rỗng hoặc chưa được tạo");
                return;
            }
            var xx = File.ReadAllLines(path);
            if (xx[0] == "")
                return;
            arr = new int[int.Parse(xx[0]), int.Parse(xx[0])];
            for (int j = 1; j < xx.Length; j++)
            {
                var s = xx[j].Split(' ');
                arr[int.Parse(s[0]), int.Parse(s[1])] = 1;
                arr[int.Parse(s[1]), int.Parse(s[0])] = 1;
            }
        }

        HinhTron LayHinhTron(int ten)
        {
            foreach (var item in tapDinhDt)
            {
                if (item.Ten == ten.ToString())
                    return item;
            }
            return null;
        }

        //    thêm đỉnh từ file lên form

        void VeLaiDinh()
        {
            string path = "D:\\FileDinh.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("file không tồn tại");
                return;
            }

            var xx = File.ReadAllLines(path);

            foreach (var item in xx)
            {
                var s = item.Split(';');
                ThemDinh(int.Parse(s[0]), int.Parse(s[1]));
            }
        }

        #endregion

        #region Thao TacTren file text
        //lưu file có 2 hàm tọa độ và arr
        public void LuuFile()
        {
            LuuDinhVaoFile();
            LuuFileArr();
        }

        private void LuuFileArr()
        {
            string path = "D:\\FileArr.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            if (arr.GetLength(0) == 0)
            {
                if (MessageBox.Show("bạn có muốn lưu file rỗng 0", "thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string appendText1 = Environment.NewLine;
                    File.AppendAllText(path, appendText1);
                    string path1 = "D:\\FileDinh.txt";
                    File.Delete(path1);

                }
            }
            string appendText = arr.GetLength(0).ToString() + Environment.NewLine;
            File.AppendAllText(path, appendText);

            foreach (var item in tapCanh)
            {
                var appendTextcanh = item.DiemDau.Ten + " " + item.DiemCuoi.Ten + Environment.NewLine;
                File.AppendAllText(path, appendTextcanh);
            }
        }

        #endregion


        Color Mau()
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

        internal void ToMau()
        {
            if (tapDinhDt.Count == 0)
            {
                MessageBox.Show("file chưa được đọc cần đọc file");
                return;
            }
            var soDoThi = DemDoThi();
            ToMauCacDoThi(soDoThi);

        }

        public void ToMauCacDoThi(List<Hinh> soDoThi)
        {
            foreach (var item in soDoThi)
            {
                var color = Mau();
                VeCacCanhTren1DoThi(item, color);
            }
        }

        public void ToMauMotDoThi(Hinh dothi)
        {
            var color = Mau();
            VeCacCanhTren1DoThi(dothi, color);
        }

        void VeCacCanhTren1DoThi(Hinh doThi, Color color)
        {

            foreach (var item in doThi.tapCanh)
            {
                item.DiemCuoi.Color = color;
                VeCanh(item);
            }
            foreach (var Dinh in doThi.tapDinh)
                Dinh.Color = color;

        }

        internal void DocFile()
        {
            DocFileDinh();
            DocFileArr();
        }

        private void DocFileDinh()
        {
            VeLaiDinh();
        }

        private void DocFileArr()
        {
            VeLaiCanh();
        }

        public Hinh TimDuong(int bd, int kt)
        {
            var doThi = DemDoThi();
            var ret = new Hinh();
            foreach (var item in doThi)
                if (CoDuongDi(item, bd) && CoDuongDi(item, kt))
                {
                    ret = item;
                    ToMauMotDoThi(ret);
                }
            return ret;
        }

        int LayTenDinh(Canh canh, int bd)
        {
            if (canh.DiemDau.Ten == bd.ToString())
                return int.Parse(canh.DiemCuoi.Ten);
            return int.Parse(canh.DiemDau.Ten);
        }

        List<int> DinhDaDuyet(List<int> daDuyet)
        {
            var dinhDaDuyet = new List<int>();
            foreach (var item in daDuyet)
            {
                dinhDaDuyet.Add(item);
            }
            return dinhDaDuyet;
        }

        void LayDuongDi(int bd, int kt, Hinh dothi, List<Hinh> tapDuongDi, Hinh duongMin, List<Canh> cacCanhKe, List<int> dinhDaDuyet)
        {
            var cacCanhKeDinhMoi = LayCanhTuHinh(dothi, bd, cacCanhKe);
            var dinhDuyet = DinhDaDuyet(dinhDaDuyet);
            foreach (var item in cacCanhKeDinhMoi)
            {
                var hinhMoi = new Hinh();
                var dinhMoi = LayTenDinh(item, bd);
                if (!duongMin.tapCanh.Contains(item))
                {
                    if (DinhDaDuocDuyet(dinhMoi, dinhDuyet))
                        continue;
                    dinhDuyet.Add(bd);
                    foreach (var dinh in duongMin.tapDinh)
                    {
                        hinhMoi.tapDinh.Add(dinh);
                    }
                    foreach (var dinh in duongMin.tapCanh)
                    {
                        hinhMoi.tapCanh.Add(dinh);
                    }
                    hinhMoi.tapDinh.Add(LayHinhTron(bd));
                    hinhMoi.tapCanh.Add(item);
                    if (dinhMoi == kt)
                    {
                        hinhMoi.tapDinh.Add(LayHinhTron(kt));
                        tapDuongDi.Add(hinhMoi);
                        continue;
                    }

                    LayDuongDi(dinhMoi, kt, dothi, tapDuongDi, hinhMoi, cacCanhKeDinhMoi, dinhDuyet);
                }
            }
        }

        bool DinhDaDuocDuyet(int dinh, List<int> dinhDaDuyet)
        {
            foreach (var item in dinhDaDuyet)
            {
                if (item == dinh)
                    return true;
            }
            return false;
        }

        Hinh HinhMin(Hinh hinhMoi, Hinh Hinh)
        {
            if (hinhMoi.tapCanh.Count > Hinh.tapCanh.Count)
                return Hinh;
            return hinhMoi;
        }

        List<Canh> LayCanhTuHinh(Hinh dothi, int ten, List<Canh> cacCanhKe)
        {
            var cacCanhKeDinhMoi = new List<Canh>();
            foreach (var item in dothi.tapCanh)
                if (item.DiemDau.Ten == ten.ToString() || item.DiemCuoi.Ten == ten.ToString())
                {
                    var canh = new Canh();
                    canh = item;
                    if (!cacCanhKe.Contains(canh))
                        cacCanhKeDinhMoi.Add(canh);
                }
            return cacCanhKeDinhMoi;
        }

        bool CoDuongDi(Hinh dothi, int dinh)
        {
            if (dothi.tapDinh.Count < 2)
                return false;

            foreach (var item in dothi.tapDinh)
                if (item.Ten == dinh.ToString())
                    return true;
            return false;
        }

        internal void TimDuongMin(int bd, int kt)
        {
            var dothi = TimDuong(bd, kt);
            var cacDuongDi = new List<Hinh>();
            LayDuongDi(bd, kt, dothi, cacDuongDi, new Hinh(), new List<Canh>(), new List<int>());
            if (cacDuongDi.Count == 0)
            {
                MessageBox.Show("không có đường");
                return;
            }
            var duongMin = cacDuongDi[0];
            foreach (var duong in cacDuongDi)
            {
                if (duongMin.tapCanh.Count >= duong.tapCanh.Count)
                    duongMin = duong;
            }
            ToMauMotDoThi(duongMin);
            MessageBox.Show("đã tô màu đường đi từ" + bd.ToString() + "đến" + kt.ToString());
        }
    }
}
