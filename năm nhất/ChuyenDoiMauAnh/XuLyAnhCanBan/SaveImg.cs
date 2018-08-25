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
    public partial class SaveImg : Form
    {
        public SaveImg()
        {
            InitializeComponent();
        }
        public string FileName
        {
            get
            {
                return txtName.Text;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("chưa nhập tên");
                return;
            }
            this.Close();
        }
    }
}
