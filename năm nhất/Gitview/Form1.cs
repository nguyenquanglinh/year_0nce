using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gitview
{
    public partial class Form1 : Form
    {
        string ten, gioiTinh, diaChi, tuoi;
        IPersonStore store = new FileStore();

        private void btnSave_Click(object sender, EventArgs e)
        { 
            ThongTin();
            Nguoi peoPle = new Nguoi(ten, tuoi, gioiTinh, diaChi);
            store.SaveOne(peoPle);
        }

        List<Nguoi> dsNguoi = new List<Nguoi>();

        public Form1()
        {
            InitializeComponent();
            GridviewBang.AutoGenerateColumns = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dsNguoi = store.LoadAll();
            this.GridviewBang.DataSource = dsNguoi;
            GridviewBang.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongTin();
            GridviewBang.Rows.Add(ten, tuoi, gioiTinh, diaChi);
        }

        void ThongTin()
        {
            if (cbGioiTinh.Checked)
            {
                gioiTinh = "nam";
            }
            else
                gioiTinh = "nu";
            ten = txtTen.Text;
            tuoi = txtTuoi.Text;
            diaChi = txtDiaChi.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GridviewBang.RowCount <= 0)
            {
                MessageBox.Show("bang chua tao");
            }
            else
            {
                int row = GridviewBang.CurrentCell.RowIndex;
                GridviewBang.Rows.RemoveAt(row);
            }
        }


    }
}
