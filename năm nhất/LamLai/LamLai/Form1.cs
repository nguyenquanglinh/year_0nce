using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamLai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                var x = new Nguoi( );
                bds.Add(x);
            }
            ChuyenDuLieu(bds[bds.Count-1]);
        }

        private void ChuyenDuLieu(object nguoi)
        {
            if (nguoi is Nguoi)
            {
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add(new Binding("Text", nguoi, "Name"));
                txtAge.DataBindings.Clear();
                txtAge.DataBindings.Add(new Binding("Text", nguoi, "Age"));
                txtGender.DataBindings.Clear();
                txtGender.DataBindings.Add(new Binding("Text", nguoi, "Gender"));
                txtAdress.DataBindings.Clear();
                txtAdress.DataBindings.Add(new Binding("Text", nguoi, "Adress"));
            }
            else
            {
                MessageBox.Show("đây không phải thông tin 1 người");
                return;
            }
        }

        private void bds_CurrentItemChanged(object sender, EventArgs e)
        {
            ChuyenDuLieu(bds.Current);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bds.CurrentItemChanged += bds_CurrentItemChanged;
            bds.ListChanged += Bds_ListChanged;
            txtAge.Validating += txtAge_Validating;
        }

        private void Bds_ListChanged(object sender, ListChangedEventArgs e)
        {
            txtStt.Text = (bds.Count).ToString();

            for (int i = 0; i < bds.Count; i++)
            {
                (bds[i] as Nguoi).Stt = i+1 ;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            var intt = int.Parse(txt.Text);
            try
            {
                if (intt > 150 || intt < 0)
                {
                    error.SetError(txt, "nhập sai rồi");
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {
                error.SetError(txt, "sai");
            }
        }

        private void txtStt_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("bang chua tao");
            }
            else
            {
                int row = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows.RemoveAt(row);
            }
        }

        private void txtStt_Enter(object sender, EventArgs e)
        {
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int row = int.Parse(txtStt.Text);
           
                MessageBox.Show((bds[row-1] as Nguoi).ToString());
            ;
        }
    }
}
