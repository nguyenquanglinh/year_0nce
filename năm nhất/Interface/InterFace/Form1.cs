using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterFace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bdn.Add(new Nguoi());
            ThemThongTinGridview(bdn[bdn.Count - 1]);
        }

        private void ThemThongTinGridview(object v)
        {
            if (v is Nguoi)
            {
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add(new Binding("Text", v, "Name"));
                txtAge.DataBindings.Clear();
                txtAge.DataBindings.Add(new Binding("Text", v, "Age"));
                txtAdress.DataBindings.Clear();
                txtAdress.DataBindings.Add(new Binding("Text", v, "Adress"));
            }
            else
            {
                MessageBox.Show("chưa nhập thông tin");
                return;
            }

        }

        private void bdn_CurrentItemChanged(object sender, EventArgs e)
        {
            ThemThongTinGridview(bdn.Current);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bdn.CurrentItemChanged += bdn_CurrentItemChanged;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            var row = GridView1.CurrentCell.ColumnIndex;
            GridView1.Rows.RemoveAt(row);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void GridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
