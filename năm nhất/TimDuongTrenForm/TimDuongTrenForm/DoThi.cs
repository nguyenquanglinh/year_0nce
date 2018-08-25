using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimDuongTrenForm
{
    public class DoThi
    {
        Form form;
        int demDinh = 0;
        public List<DiemHinhTron> tapDinh;
        public List<Canh> tapCanh;
        DiemHinhTron lastedClick = null;

        public DoThi(Form f1)
        {
            form = f1;
            tapDinh = new List<DiemHinhTron>();
            tapCanh = new List<Canh>();
            f1.Paint += f1_Paint;
        }

        void f1_Paint(object sender, PaintEventArgs e)
        {
            this.Draw();
        }

        private void Draw()
        {
            GhiTenDinhLenHinhTron();
        }

        private void GhiTenDinhLenHinhTron()
        {
            demDinh = 0;
            foreach (var ht in tapDinh)
            {
                ht.NameHt = demDinh.ToString();
                demDinh++;
            }
        }

        void XoaCanh(DiemHinhTron a)
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

        DiemHinhTron VeHinhTron(int x, int y)
        {
            var ht = new DiemHinhTron() { Location = new Point(x, y) };
            ht.Color = Color.Blue;
            return ht;
        }

        public void ThemCanh(Canh canh)
        {
            if (!tapCanh.Contains(canh))
            {
                tapCanh.Add(canh);
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

        public void ThemDinh(int x, int y)
        {
            var ht = VeHinhTron(x, y)  ;

            tapDinh.Add(ht);
                form.Controls.Add(ht a);
            ht.Click += ht_Click;
            ht.DoubleClick += ht_DoubleClick;
            GhiTenDinhLenHinhTron();

        }

        public IDiem LayHinhTron(int ten)
        {
            foreach (var item in tapDinh)
            {
                if (item.NameHt == ten.ToString())
                    return item;
            }
            return null;
        }

        void ht_DoubleClick(object sender, EventArgs e)
        {
            demDinh--;
            var ht = sender as DiemHinhTron;
            for (int i = 0; i < tapDinh.Count; i++)
            {
                if (ht.Equals(tapDinh[i]))
                {
                    tapDinh.RemoveAt(i);
                }
            }
            XoaCanh(ht);
            lastedClick = null;
            form.Controls.Remove(ht);
            form.Invalidate();
        }

        void ht_Click(object sender, EventArgs e)
        {
            var ht = sender as DiemHinhTron;
            ht.Color = Color.Red;
            if (lastedClick == null)
            {
                lastedClick = ht;
                return;
            }
            if (ht.Equals(lastedClick))
            {
                ht.Color = Color.Blue;
                lastedClick = null;
                return;
            }
            var canh = new Canh(lastedClick, ht);
            ThemCanh(canh);
            lastedClick = null;
        }

        private bool OverLap(IDiem ht)
        {
            foreach (var item in this.tapDinh)
                if (ht.Overlap(item))
                    return true;
            return false;
        }



    }
}
