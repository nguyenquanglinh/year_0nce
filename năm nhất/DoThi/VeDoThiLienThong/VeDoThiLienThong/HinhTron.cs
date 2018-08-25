using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeDoThiLienThong
{
    public partial class HinhTron : UserControl
    {
        public HinhTron()
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


        public string Ten
        {
            get
            {
                return txtTen.Text;
            }
            set
            {
                txtTen.Text = value;
                if (string.IsNullOrEmpty(value))
                    txtTen.Text = "Đỉnh";
            }
        }

        /// <summary>
        /// Kiểm tra xem hai hinh tron co bi de len nhau hay khong 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Overlap(HinhTron other)
        {
            return other.Bounds.IntersectsWith(this.Bounds);
        }

        private void HinhTron_Load(object sender, EventArgs e)
        {
            Ten = txtTen.Text;
            this.txtTen.Click += txtTen_Click;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush sb = new SolidBrush(Color);
            Graphics g = this.CreateGraphics();
            g.FillEllipse(sb, 0, 0, 50, 50);
            g.Dispose();
            sb.Dispose();
        }

        void txtTen_Click(object sender, EventArgs e)
        {
            base.OnClick(new EventArgs());
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Location.X.GetHashCode() ^ this.Location.Y.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var ht = obj as HinhTron;
            if (ht == null)
                return false;
            return this.GetHashCode() == ht.GetHashCode();
        }

        private void HinhTron_DoubleClick(object sender, EventArgs e)
        {
            var ht = sender as HinhTron;
            ht.Refresh();
            this.Controls.Remove(ht);
        }


    }
}
