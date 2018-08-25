using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessCaro
{
    public partial class Form1 : Form
    {
        ChessCaro chesCaro;
        const int steep = 10;
        const int timer = 1000;
        const int internall = 100;
        public Form1()
        {
            InitializeComponent();
            chesCaro = new ChessCaro(pnlChessBoard, txtPlayer, ptbPlayer);
            NewGame();
            chesCaro.KetThuc += chesCaro_KetThuc;
            chesCaro.NguoiChoi += chesCaro_NguoiChoi;
            prbTime.Step = steep;
            prbTime.Maximum = timer;
            prbTime.Value = 0;
            timer1.Interval = internall;
        }

        //các ham su dụng trem form

        void EndGame()
        {
            timer1.Stop();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            MessageBox.Show("the and");
        }

        void NewGame()
        {
            chesCaro.NewChessBoard();
            undoToolStripMenuItem.Enabled = true;
        }

        void Undo()
        {
            chesCaro.Undo();
        }

        void Exit()
        {
            Application.Exit();
        }

        //hàm khởi tạo tính thời gian

        void chesCaro_NguoiChoi(object sender, EventArgs e)
        {
            timer1.Start();
            prbTime.Value = 0;
        }

        void chesCaro_KetThuc(object sender, EventArgs e)
        {
            EndGame();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            prbTime.PerformStep();
            if (prbTime.Value >= timer)
            {
                EndGame();
            }
        }


        //value menu
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prbTime.Value = 0;
            timer1.Stop();
            NewGame();

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void btnLan_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }

        private void prbTime_Click(object sender, EventArgs e)
        {

        }
    }
}
