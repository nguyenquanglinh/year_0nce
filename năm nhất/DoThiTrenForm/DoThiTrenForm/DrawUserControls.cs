using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
namespace DoThiTrenForm
{

    public class GrapDrawler : IGraphDrawler
    {
        public Panel f1;

        public GrapDrawler(Panel f1)
        {
            this.f1 = f1;
        }

        public void DrawDiem(IDiem diem)
        {
            f1.Controls.Add(diem as UserControl);
        }

        void Draw(ICanh canh)
        {
            var dDau = canh.DiemDau;
            var dCuoi = canh.DiemCuoi;

            using (Graphics g = f1.CreateGraphics())
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen p = new Pen(canh.Color, 2))
                    g.DrawLine(p, dDau.Center, dCuoi.Center);
            }
        }

        public void Draw(IDoThi doThi)
        {
            foreach (var item in doThi.TapDinh)
            {
                this.f1.Controls.Add(item as UserControl);
            }
            UpdateEdge(doThi);
        }

        public void UpdateEdge(IDoThi doThi)
        {
            foreach (var item in doThi.TapCanh)
                Draw(item);

        }

        public void DrawHinh(Hinh ss)
        {
            var color = MauSac();
            foreach (var dinh in ss.TapDinh)
            {
                dinh.Color = color;
                this.f1.Controls.Add(dinh as Diem);
            }
            foreach (var canh in ss.TapCanh)
            {
                canh.Color = color;
                Draw(canh);
            }
        }

        private Color MauSac()
        {
            var tapMau = new List<Color>() { Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.Aquamarine, Color.Azure, Color.Black, Color.BlanchedAlmond, Color.BurlyWood };
            var ranDom = new Random();
            return tapMau[ranDom.Next(0, tapMau.Count)];

        }
    }
}
