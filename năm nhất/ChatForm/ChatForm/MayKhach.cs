using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ChatLib;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatLib.MessageModel;
using System.IO;

namespace ChatForm
{
    public partial class MayKhach : Form
    {

        #region biến toan cục của phần chát
        ClientChat client;
        #endregion

        #region biến của bàn cơ
        const int steep = 10;
        const int timer = 1000;
        const int internall = 100;
        #endregion

        /// <summary>
        /// tạo máy khách
        /// </summary>
        public MayKhach()
        {
            InitializeComponent();

            #region luồng của phần chát
            CheckForIllegalCrossThreadCalls = false;
            client = new ClientChat(2302);
            client.Processor.Add(new SendProcess(this));
            #endregion

            #region phân của bàn cờ
            prbTime.Step = steep;
            prbTime.Maximum = timer;
            prbTime.Value = 0;
            timer1.Interval = internall;
            #endregion
        }
        public ManagerPlayer managerPlayer { get; set; }

        #region Phần chát

        //gửi sai đối tượng  //chưa có người nhận
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            client.Send(new SendMessage(txtUserName.Text, managerPlayer.GetNamePlayer(player), txtMessage.Text, false));
            ThemCauChat(txtMessage.Text);
        }
        //gửi sai đối tượng
        private void btnSendFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var file = File.ReadAllBytes(open.FileName);
                if (file.Length < 1025)
                    client.Send(new SendFile(txtUserName.Text, File.ReadAllBytes(open.FileName), managerPlayer.GetNamePlayer(player), Path.GetFileName(open.FileName)));
                else
                {

                    client.Send(new SendFileBig(txtUserName.Text, managerPlayer.GetNamePlayer(player), Path.GetFileName(open.FileName), new byte[1026]));
                }
                ThemCauChat("đã gửi file " + open.FileName);
            }
        }

        //        private List<byte[]>ConvertDatabig(byte[]dataBig)
        //        {
        //return             
        //        }


        private void ThemCauChat(string cauChat)
        {
            KhungChat.AppendText("\n" + txtUserName.Text + ": " + cauChat);
            txtMessage.Clear();
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            client.Connect(txtUserName.Text);

        }


        #region class gửi tin nhắn

        class SendProcess : ChatLib.MessagerProcessorBase
        {
            MayKhach form;
            //1 hàm tạo
            public SendProcess(MayKhach form)
            {
                this.form = form;
            }
            public override void Process(ReceiveClientClose receiClientClose)
            {
                this.form.menuStrip1.Enabled = false;
                this.form.EndGame();
                MessageBox.Show("you is winer");

            }

            //2 tên máy khách kết nối thành công
            public override void Process(ChatLib.MessageModel.ConnectMessageSuccess message)
            {
                this.form.Text = message.NameSender;
                this.form.btnFind.Enabled = true;
            }
            //3 gửi tin nhắn thất bại
            public override void Process(ChatLib.MessageModel.ConnecMessageFaile message)
            {
                this.form.KhungChat.AppendText(message.Exception + "\n");
            }
            //5 nhận được file
            public override void Process(ChatLib.MessageModel.RecievedFile message)
            {
                this.form.KhungChat.AppendText("Recieve from " + message.NameSender + " file name:" + message.FileName);
                File.WriteAllBytes("d:/chat/" + message.FileName, message.ByteData);

            }
            //4 nhận được tin nhắn
            public override void Process(ChatLib.MessageModel.RecievedMessage message)
            {
                if (message.isLoaction == false)
                {
                    this.form.KhungChat.AppendText(string.Format("{0}: {1} \n", message.From, message.Message));
                }
                else
                {
                    this.form.txtHienTai.Text = this.form.txtUserName.Text;
                    this.form.boardCaro1.Wait = false;
                    this.form.boardCaro1.GesterClick(message.Message, this.form.managerPlayer.GetPlayer(this.form.player));

                }
            }

            public override void Process(SendInvation message)
            {
                if (MessageBox.Show(message.NameSender + " mời bạn chơi bạn có đồng ý không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    this.form.client.Send(new ReciveInvation(this.form.txtUserName.Text, message.NameSender, true));
                    var mester = new Player(message.NameSender, Image.FromFile("D:\\BaiTap1\\GameCaro\\ChatCaro\\Resources\\1.png"), 1);
                    var guseter = new Player(this.form.txtUserName.Text, Image.FromFile("D:\\BaiTap1\\GameCaro\\ChatCaro\\Resources\\3.png"), 3);
                    this.form.managerPlayer = new ManagerPlayer(guseter, mester);
                    this.form.player = guseter;
                    this.form.NewGame(guseter);
                }
                else
                    this.form.client.Send(new ReciveInvation(this.form.txtUserName.Text, message.NameSender, false));
            }

            public override void Process(ReciveInvation reciveDecLinedInvation)
            {
                if (reciveDecLinedInvation.IsInvation == false)
                    MessageBox.Show(reciveDecLinedInvation.NameSender + ": không đồng ý chơi");
                else
                {
                    //đồng ý chơi =>> thằng mời chơi là X, được mời chơi là 0
                    var guseter = new Player(reciveDecLinedInvation.NameSender, Image.FromFile("D:\\BaiTap1\\GameCaro\\ChatCaro\\Resources\\3.png"), 3);
                    var mester = new Player(this.form.txtUserName.Text, Image.FromFile("D:\\BaiTap1\\GameCaro\\ChatCaro\\Resources\\1.png"), 1);
                    this.form.managerPlayer = new ManagerPlayer(mester, guseter);
                    this.form.player = mester;
                    this.form.NewGame(mester);
                }
            }

            public override void Process(ReceiFindPlayer receiFindPlayer)
            {
                var listmayKhach = receiFindPlayer.UserNamePlayer;
                foreach (var li in listmayKhach)
                {
                    if (String.IsNullOrEmpty(li) || li == this.form.txtUserName.Text)
                        continue;
                    this.form.cbbPlayerName.Items.Add(li);
                }

            }
        }
        #endregion

        #endregion

        #region bàn cờ

        private void EndGame()
        {
            timer1.Stop();
            boardCaro1.EndGame();
        }

        private void NewGame(Player player)
        {
            this.Invoke(new Action(() =>
            {
                menuStrip1.Enabled = true;
                boardCaro1.NewChessBoard(boardCaro1.Height, boardCaro1.Width - groupBox1.Width, player);
                boardCaro1.PlayerClick -= chessBoardCaro1_NguoiChoi;
                boardCaro1.PlayerClick += chessBoardCaro1_NguoiChoi;
                boardCaro1.ketThuc -= chessBoardCaro1_ketThuc;
                boardCaro1.ketThuc += chessBoardCaro1_ketThuc;
            }));
        }

        void chessBoardCaro1_ketThuc(object sender, EventArgs e)
        {
            EndGame();
        }

        void chessBoardCaro1_NguoiChoi(object sender, EventArgs e)
        {
            ThongTin();
            timer1.Start();
            prbTime.Value = 0;
        }

        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            client.Send(new SendInvation(txtUserName.Text, managerPlayer.GetNamePlayer(player)));
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormClose();
            this.Close();
        }

        private void FormClose()
        {
            if (client.Client != null)
                if (MessageBox.Show("bạn sẽ thua nếu thoát game ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    client.Send(new SendClientClose(txtUserName.Text, managerPlayer.GetNamePlayer(player)));
                }
        }

        Player player;
        private void ThongTin()
        {
            txtHienTai.Text = managerPlayer.GetNamePlayer(player);
            btnHienTai.BackgroundImage = managerPlayer.GetPlayer(player).PlayerPhoto;
            client.Send(new SendMessage(txtUserName.Text, managerPlayer.GetNamePlayer(player), boardCaro1.stringLocation, true));
            boardCaro1.Wait = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            prbTime.PerformStep();
            if (prbTime.Value >= timer)
            {
                EndGame();
                MessageBox.Show("winer is : " + txtUserName.Text);
            }
        }
        #endregion

        private void btnFind_Click(object sender, EventArgs e)
        {
            cbbPlayerName.Items.Clear();
            client.Send(new SendFindPlayer(txtUserName.Text));
        }

        private void cbbPlayerName_SelectedIndexChanged(object sender, EventArgs e)
        {

            var playerName = (string)cbbPlayerName.SelectedItem;
            menuStrip1.Enabled = true;
            client.Send(new SendInvation(txtUserName.Text, playerName));
        }

        private void btnSendFileBig_Click(object sender, EventArgs e)
        {
        }
        //gửi thông báo tắt
        private void MayKhach_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClose();
        }
    }

    public class ManagerPlayer
    {

        public ManagerPlayer(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
        }

        public string GetNamePlayer(Player player)
        {
            if (player.NamePlayer == Player1.NamePlayer)
                return Player2.NamePlayer;
            else return Player1.NamePlayer;
        }

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Player GetPlayer(Player player)
        {
            if (player.Index == Player1.Index)
                return Player2;
            else
                return Player1;
        }
    }
}
