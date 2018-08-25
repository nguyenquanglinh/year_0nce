using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCaro
{
    public partial class Form1 : Form
    {
        const int steep = 10;
        const int timer = 1000;
        const int internall = 100;
        public Form1()
        {
            InitializeComponent();
            prbTime.Step = steep;
            prbTime.Maximum = timer;
            prbTime.Value = 0;
            timer1.Interval = internall;
        }
        private void EndGame()
        {
            timer1.Stop();
            chessBoardCaro1.EndGame();

        }
        private void NewGame()
        {
            chessBoardCaro1.NewChessBoard(chessBoardCaro1.Height, chessBoardCaro1.Width - groupBox1.Width, "linh", "quang");
            chessBoardCaro1.ImformationPlayer -= chessBoardCaro1_NguoiChoi;
            chessBoardCaro1.ImformationPlayer += chessBoardCaro1_NguoiChoi;
            chessBoardCaro1.ketThuc -= chessBoardCaro1_ketThuc;
            chessBoardCaro1.ketThuc += chessBoardCaro1_ketThuc;

        }

        void chessBoardCaro1_ketThuc(object sender, EventArgs e)
        {
            EndGame();
            MessageBox.Show("winer is : " + chessBoardCaro1.NamePlayerCurrent);
        }

        void chessBoardCaro1_NguoiChoi(object sender, EventArgs e)
        {
            ThongTin();
            timer1.Start();
            prbTime.Value = 0;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTin()
        {
            //cần gửi tọa độ đi
            txtHienTai.Text = chessBoardCaro1.NamePlayerCurrent;
            btnHienTai.BackgroundImage = chessBoardCaro1.PhotoPlayerCurrunt;
            txtTiepTheo.Text = chessBoardCaro1.NamePlayerNext;
            btnTiepTheo.BackgroundImage = chessBoardCaro1.PhotoPlayerNext;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prbTime.PerformStep();
            if (prbTime.Value >= timer)
            {
                EndGame();
                MessageBox.Show("winer is : " + chessBoardCaro1.NamePlayerCurrent);
            }
        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("thay đổi");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }




    }



}
