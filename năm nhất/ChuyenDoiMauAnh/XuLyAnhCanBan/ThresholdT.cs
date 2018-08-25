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
    public partial class ThresholdT : Form
    {
        public ThresholdT()
        {
            InitializeComponent();
        }
        public int T { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNguongT.Text))
                return;
            this.T = int.Parse(txtNguongT.Text);
            this.Close();
        }

    }
}
