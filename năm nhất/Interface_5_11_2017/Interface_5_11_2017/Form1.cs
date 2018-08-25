using Interface_5_11_2017;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_5_11_2017
{
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
        }

        IPeopleStore store;

        private void Form1_Load(object sender, EventArgs e)
        {
            bdn.CurrentItemChanged += bdn_CurrentItemChanged;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bdn.Add(new Nguoi());
            AddImformation(bdn[bdn.Count - 1]); 
        }

        private void AddImformation(object v)
        {
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add(new Binding("Text", v, "Name"));
            txtAge.DataBindings.Clear();
            txtAge.DataBindings.Add(new Binding("Text", v, "Age"));
            TxtAddress.DataBindings.Clear();
            TxtAddress.DataBindings.Add(new Binding("Text", v, "Address"));
            cbbGender.DataBindings.Clear();
            cbbGender.DataBindings.Add(new Binding("SelectedItem", v, "Gender"));
        }


        private void bdn_CurrentItemChanged(object sender, EventArgs e)
        {
            AddImformation(bdn.Current);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var row = GridView1.CurrentCell.RowIndex;
            GridView1.Rows.RemoveAt(row);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (store == null)
            {
                MessageBox.Show("Data is ??");
                return;
            }
            var list = new List<Nguoi>();
            foreach (Nguoi item in bdn)
            {
                list.Add(item);
            }

            store.SaveAll(list);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var listPeople = store.LoadAll();
            if (listPeople.Count == 0)
                return;

            foreach (var item in listPeople)
                this.bdn.Add(item);

            GridView1.Refresh();
        }

        private void cbbUse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbUse_SelectedValueChanged(object sender, EventArgs e)
        {
            var x = cbbUse.SelectedItem;
            if (x is Memory)
            {
                store = new Memory();
            }
            else
                store = new PeopleStore();
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            int number;
            if (txt.Text == "chưa nhâp tuổi")
            {
                number = 1;
            }
            number = int.Parse(txt.Text);
            try
            {
                if (number < 0 || number >= 150)
                {
                    error.SetError(txt, "nhập sai  rồi");
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {
                error.SetError(txt, "nhập sai  rồi");
            }
        }

    }
}
