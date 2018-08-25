using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTen.ReadOnly = true;
            txtTuoi.ReadOnly = true;
            gridview1.ReadOnly = true;
            bdn.CurrentItemChanged += bdn_CurrentItemChanged;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
        }

        private void ThemThongTin(object v)
        {
            if (v is Nguoi)
            {
                txtTen.DataBindings.Clear();
                txtTen.DataBindings.Add(new Binding("Text", v, "Name"));
                txtTuoi.DataBindings.Clear();
                txtTuoi.DataBindings.Add(new Binding("Text", v, "Age"));
            }
            else
            {
                MessageBox.Show("đây k phải là người");
                return;
            }
        }

        private void bdn_CurrentItemChanged(object sender, EventArgs e)
        {
            ThemThongTin(bdn.Current);
        }

        private void txtTuoi_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            var number = 1;
            if (txt.Text == "")
                number = 1;
            else
                number = int.Parse(txt.Text);
            try
            {
                if (number < 1 || number > 150)
                {
                    error.SetError(txt, "nhập sai rồi");
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {

                error.SetError(txt, "nhâp sai rồi");
            }
        }

        private void gridview1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f2 = new Form2(bdn);
            f2.Show();
        }

        private void bdn_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTen.ReadOnly = false;
            txtTuoi.ReadOnly = false;
            gridview1.ReadOnly = false;
            if (bdn.Count == 0)
                bdn.Add(new Nguoi(txtTen.Text, txtTuoi.Text));
            else
                bdn.Add(new Nguoi());
            ThemThongTin(bdn[bdn.Count - 1]);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview1.ColumnCount == 0)
            {
                MessageBox.Show("bảng không có thông tin");
                return;
            }
            else
            {
                var row = gridview1.CurrentCell.ColumnIndex;
                gridview1.Rows.RemoveAt(row);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           bdn.CancelEdit();
            //bdn.ResetCurrentItem();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
