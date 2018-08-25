using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimDuongTrenForm
{
    public partial class DiemHinhTron : UserControl
    {
        public DiemHinhTron()
        {
            InitializeComponent();
        }
        public Point Center
        {
            get
            {
                return new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height / 2);
            }
        }
        Color color;
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                this.Invalidate();

            }

        }

        public string NameHt
        {
            get
            {
                return txtName.Text;
            }
            set
            {
                txtName.Text = value;
                if (string.IsNullOrEmpty(value))
                    txtName.Text = "ht";
            }
        }

        public bool Overlap(DiemHinhTron other)
        {
            return other.Bounds.IntersectsWith(this.Bounds);
        }

        private void DiemHinhTron_Load(object sender, EventArgs e)
        {
            this.txtName.Click += txtName_Click;
        }

        void txtName_Click(object sender, EventArgs e)
        {
            base.OnClick(new EventArgs());
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
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Location.X.GetHashCode() ^ this.Location.Y.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var ht = obj as DiemHinhTron;
            if (ht == null)
                return false;
            return this.GetHashCode() == ht.GetHashCode();
        }

        private void DiemHinhTron_DoubleClick(object sender, EventArgs e)
        {
            var ht = sender as DiemHinhTron;
            ht.Refresh();
            this.Controls.Remove(ht);
        }



    }
}
