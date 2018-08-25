using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThiTrenForm
{
    public class DoThi : IDoThi
    {
        public IDiem this[string name]
        {
            get
            {
                return TapDinh.FirstOrDefault(x => x.PointName.Equals(name));
            }
        }

        private List<IDiem> tapDinh = new List<IDiem>();

        private List<ICanh> tapCanh = new List<ICanh>();

        public IEnumerable<IDiem> TapDinh
        {
            get
            {
                return tapDinh;
            }
        }

        public IEnumerable<ICanh> TapCanh
        {
            get
            {
                return tapCanh;
            }
        }

        public void ThemCanh(Canh canh)
        {
            if (!tapCanh.Contains(canh))
            {
                tapCanh.Add(canh);
                NotifyChanged();
            }
        }

        public void ThemDinh(IDiem diemDinh)
        {
            if (tapDinh.Contains(diemDinh))
                return;
            tapDinh.Add(diemDinh);
            GhiTenDiem();

            diemDinh.OnDoubleClickK += diemDinh_OnDoubleClick;
            diemDinh.ClickOn += diemDinh_ClickOn;
        }

        IDiem lastedClick;

        void diemDinh_ClickOn(object sender, DiemClickedArgs e)
        {
            var ht = sender as IDiem;
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
            ht.Color = Color.Blue;
            lastedClick.Color = Color.Blue;
            this.ThemCanh(new Canh(ht, lastedClick));
            lastedClick = null;

        }

        private void GhiTenDiem()
        {
            int dem = 0;
            foreach (var diem in this.TapDinh)
            {
                diem.PointName = dem.ToString();
                dem++;
            }
        }

        private void diemDinh_OnDoubleClick(object sender, DiemDoubleClickedArgs e)
        {
            XoaMotDiem(this[e.Name]);
            NotifyChanged();
            lastedClick = null;
        }

        public void XoaMotDiem(IDiem diemClick)
        {
            this.tapDinh.Remove(this[diemClick.PointName]);

            foreach (var item in tapCanh.ToArray())
            {
                if (item.DiemDau.Equals(diemClick) || item.DiemCuoi.Equals(diemClick))
                {
                    tapCanh.Remove(item);
                }
            }

        }


        void NotifyChanged()
        {
            if (this.OnGraphChanged != null)
                OnGraphChanged(this, new EventArgs());
        }

        public event EventHandler OnGraphChanged;


        public int SoDinhCuaDoThi
        {
            get { return this.tapDinh.Count; }
        }
    }
}
