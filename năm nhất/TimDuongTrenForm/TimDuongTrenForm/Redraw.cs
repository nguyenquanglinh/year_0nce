using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimDuongTrenForm
{
    interface Redraw
    {
        void Draw(Canh canh);
    }
    public class NewForm : Redraw
    {
        Form1 f1;
        public NewForm(Form1 f1)
        {
            this.f1 = f1;
        }
        public void Draw(Canh canh)
        {
            var dDau = canh.DiemDau;
            var dCuoi = canh.DiemCuoi;
            var color = dCuoi.Color;
            using (Graphics g = f1.CreateGraphics())
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen p = new Pen(color, 2))
                {
                    g.DrawLine(p, dDau.Center, dCuoi.Center);
                }
            }
        }


    }

}
