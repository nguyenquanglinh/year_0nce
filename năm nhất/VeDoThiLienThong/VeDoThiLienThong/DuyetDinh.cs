using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeDoThiLienThong
{
    public partial class Form2 : Form
    {
        DoThi dt { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(DoThi doThi)
            : this()
        {
            dt = doThi;
            if (dt == null)
            {
                this.Close();
            }
            New();
        }

        private void New()
        {
            foreach (var item in dt.tenDinh())
            {
                cbbCacDinh.Items.Add(item);
            }
        }

        private void btnDinh_Click(object sender, EventArgs e)
        {
            var tapDinhDaDuyet = dt.ThuTuDinhDuyet(dinh);
            var s = "";
            foreach (var item in tapDinhDaDuyet.tapDinh)
                s += item.Ten.ToString() + "=>";
            s = s.Remove(s.Length - 2, 2);
            MessageBox.Show(s);
            KetThuc();
        }
        void KetThuc()
        {
            if (MessageBox.Show("bạn có muốn thoát không", "thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                this.Close();
            New();

        }
        int dinh;
        private void cbbCacDinh_SelectedValueChanged(object sender, EventArgs e)
        {
            dinh = int.Parse(cbbCacDinh.SelectedItem.ToString());
        }


    }
}
#region chưa làm dk
//private void txtDinh_Validating(object sender, CancelEventArgs e)
//{
//    var txt = sender as TextBox;

//    try
//    {
//        int so;
//        bool laSo = int.TryParse(txt.Text, out so);
//        if (!laSo || so < 0)
//        {
//            err.SetError(txt, "nhập sai");

//        }

//    }
//    catch (Exception)
//    {

//        throw;
//    }
//}

//private void btnDinh_Validating(object sender, CancelEventArgs e)
//{
//    var btn = sender as Button;
//    try
//    {
//        int so;
//        bool laSo = int.TryParse(txtDinh.Text, out so);
//        if (!laSo || so < 0)
//            err.SetError(txtDinh, "nhập sai");
//    }
//    catch (Exception)
//    {

//        throw;
//    }
//}

#endregion






