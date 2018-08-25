using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSudoku
{
    public partial class GameSudoku : Form
    {
        Sudoku sdk;
        string path = "D:\\LapTrinh\\GameSudoku\\Data";
        public GameSudoku()
        {
            InitializeComponent();
            LayCauHoi();
            cacCauHoi.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        void LayCauHoi()
        {
            var tenThuMuc = Directory.GetFiles(path);
            cacCauHoi.Items.Add("abc");
            foreach (string fileName in tenThuMuc)
            {
                string tenFile = "";
                tenFile = Path.GetFileName(fileName).Trim();
                string ten = tenFile.Remove(tenFile.Length - 4, 4);
                cacCauHoi.Items.Add(ten);
            }

        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cacCauHoi.SelectedIndex = 0;
            sdk.NewSudoKu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sdk.GiaiSudoku();
            MessageBox.Show("hoàn thành");
        }

        private void cacCauHoi_SelectedValueChanged(object sender, EventArgs e)
        {
            sdk.NewSudoKu();
            var pathFile =path+"\\"+ cacCauHoi.SelectedItem+".txt";
            sdk.DocFile(pathFile);

        }

        private void btnKtKq_Click(object sender, EventArgs e)
        {
            sdk.KiemTraKetQua();
        }

    }
}
