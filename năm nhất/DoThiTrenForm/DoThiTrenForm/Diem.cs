using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoThiTrenForm
{
    public partial class Diem : UserControl, IDiem
    {
        public Diem()
        {
            InitializeComponent();
            this.Color = System.Drawing.Color.Blue;
        }

        Color color;

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                this.Invalidate();
            }
        }

        public string PointName
        {
            get { return txtName.Text; }
            set
            {
                txtName.Text = value;
                if (string.IsNullOrEmpty(value))
                    txtName.Text = "";
            }
        }

        public Point Center
        {
            get
            {
                return new Point(Location.X + Width / 2, Location.Y + Height / 2);
            }
        }

        public bool Overlap(Diem other)
        {
            return other.Bounds.IntersectsWith(this.Bounds);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush sb = new SolidBrush(Color);
            Graphics g = this.CreateGraphics();
            g.FillEllipse(sb, 0, 0, 60, 60);
            g.Dispose();
            sb.Dispose();
        }

        private void Diem_DoubleClick(object sender, EventArgs e)
        {
            if (this.OnDoubleClickK != null)
                this.OnDoubleClickK(this, new DiemDoubleClickedArgs { Name = this.PointName });
        }

        public override string ToString()
        {
            return this.Center.X.ToString() + " " + this.Center.Y.ToString();
        }

        public event EventHandler<DiemDoubleClickedArgs> OnDoubleClickK;

        public event EventHandler<DiemClickedArgs> ClickOn;

        private void Diem_Click(object sender, EventArgs e)
        {
            if (this.ClickOn != null)
                this.ClickOn(this, new DiemClickedArgs { Name = this.PointName });
        }
    }

    public class DiemClickedArgs : EventArgs
    {
        public string Name { get; set; }
    }

    public class DiemDoubleClickedArgs : EventArgs
    {
        public string Name { get; set; }

    }
}
