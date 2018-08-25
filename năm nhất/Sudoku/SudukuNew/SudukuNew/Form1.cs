using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudukuNew
{
    public partial class Form1 : Form
    {
        FileText fileTex;
        public Form1()
        {
            InitializeComponent();
            NewGame();
        }
        void NewGame()
        {
            fileTex = new FileText(cbbCauHoi);
            chessBoardSdk.NewChessBoard();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void cbbCauHoi_SelectedValueChanged(object sender, EventArgs e)
        {
            string tenFile = cbbCauHoi.SelectedItem.ToString();
            var arr = fileTex.LayDuLieuText(tenFile);
            if (arr == null)
                throw new Exception("file đã nhập sai");
            chessBoardSdk.GanArr(arr);
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            var arr = chessBoardSdk.LayArr();
            var sdk = new GiaiSudoku(arr);
            var arrkq = sdk.LayKetQua();
            chessBoardSdk.GanArr(arrkq);
            chessBoardSdk.arrDung = arrkq;
            st.Stop();
            MessageBox.Show(st.ElapsedMilliseconds.ToString());
        }

        private void btnKt_Click(object sender, EventArgs e)
        {

            if (chessBoardSdk.arrDung == null)
            {
                chessBoardSdk.arrDung = new GiaiSudoku(new int[9, 9]).LayKetQua();
                if (cbbCauHoi.SelectedItem != null)
                {
                    string tenFile = cbbCauHoi.SelectedItem.ToString();

                    var arr = fileTex.LayDuLieuText(tenFile);

                    var sdk = new GiaiSudoku(arr);
                    var arrDung = sdk.LayKetQua();
                    chessBoardSdk.arrDung = arrDung;
                }
                chessBoardSdk.KiemTraArrDung();
            }
            else
                chessBoardSdk.KiemTraArrDung();
        }


    }
}
