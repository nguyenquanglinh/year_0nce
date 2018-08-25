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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        BindingSource bnd;

        public Form2(BindingSource bnd) : this()
        {
            var x = bnd.Current as Nguoi;
            //txtTen.ReadOnly = true;
            //txtTuoi.ReadOnly = true;

            this.bnd = bnd;

            txtTen.DataBindings.Add(new Binding("Text", bnd, "Name", false, DataSourceUpdateMode.Never));
            txtTuoi.DataBindings.Add(new Binding("Text", bnd, "Age", false, DataSourceUpdateMode.Never)); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //(bnd.Current as IEditableObject).BeginEdit();
            //bnd.SuspendBinding();
            //txtTen.ReadOnly = false;
            //txtTuoi.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            txtTen.DataBindings["Text"].WriteValue();
            
          
            //(bnd.Current as IEditableObject).EndEdit();
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //(bnd.Current as IEditableObject).CancelEdit();
            Close();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtTuoi.DataBindings["Text"].WriteValue();
        }
    }
}
