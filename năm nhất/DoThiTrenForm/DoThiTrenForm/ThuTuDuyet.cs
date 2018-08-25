using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoThiTrenForm
{
    public partial class ThuTuDuyet : Form
    {
        public ThuTuDuyet()
        {
            InitializeComponent();
        }
        IDoThi dt;
        public ThuTuDuyet(IDoThi dt, Panel panel)
            : this()
        {
            this.dt = dt;
            this.panel = panel;
            CacDinhDuyet();
        }

        private void CacDinhDuyet()
        {
            foreach (var item in dt.TapDinh)
            {
                comboBox1.Items.Add(item.PointName);
            }
        }
        int dinh;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dinh = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            var dfs = new DuyetDfs(dt);
            var draw = new GrapDrawler(panel);
            var hinh = dfs.ThuTuDuyet(dinh);
            foreach (var dinhDuyet in hinh)
            {
                dinhDuyet.Color = Color.Yellow;
                draw.DrawDiem(dinhDuyet);
                MessageBox.Show(dinhDuyet.PointName);
            }
        }

        Panel panel { get; set; }
    }
}
