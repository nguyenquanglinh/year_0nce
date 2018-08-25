using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnhCanBan
{
    public partial class Threshold_a_b_ : Form
    {
        public Threshold_a_b_()
        {
            InitializeComponent();
        }
        Bitmap bitmap;

        public IXuLyAnh Xuly { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text))
                return;
            this.a = int.Parse(txtA.Text);
            this.b = int.Parse(txtB.Text);
            if (a > b)
            {
                this.a = int.Parse(txtB.Text);
                this.b = int.Parse(txtA.Text);
            }
            this.Close();
        }

        public int a { get; set; }

        public int b { get; set; }
    }
}
