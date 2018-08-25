using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimDuongTrenForm
{
    public partial class DuyetDinh : Form
    {
        private DoThi dt;

        public DuyetDinh()
        {
            InitializeComponent();
        }

        public DuyetDinh(DoThi dt)
            : this()
        {
            this.dt = dt;
            CacDinhDuyet();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
           
            var dfs = new DuyetDfs(dt);
            dfs.CacDinhDuyet(dinh);
        }

        void CacDinhDuyet()
        {
            foreach (var item in dt.tapDinh)
            {
                comboBox1.Items.Add(item.NameHt);
            }
        }

        int dinh = 0;
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            dinh = int.Parse(comboBox1.SelectedItem.ToString());
        }
    }
}
