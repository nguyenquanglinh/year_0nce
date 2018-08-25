using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowChat
{
    public partial class MayKhach : Form
    {
        Dictionary<char, char> bangMaHoa;

        public MayKhach()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            bangMaHoa = new Dictionary<char, char>();
            bangMaHoa.Add('a', 'ă');
            bangMaHoa.Add('â', 'b');
            bangMaHoa.Add('c', 'd');
            bangMaHoa.Add('đ', 'e');
            bangMaHoa.Add('ê', 'g');
            bangMaHoa.Add('h', 'i');
            bangMaHoa.Add('k', 'l');
            bangMaHoa.Add('m', 'n');
            bangMaHoa.Add('o', 'ô');
            bangMaHoa.Add('ơ', 'p');
            bangMaHoa.Add('q', 'r');
            bangMaHoa.Add('y', 'u');
            bangMaHoa.Add('ư', 'v');
            bangMaHoa.Add('t', 's');
            bangMaHoa.Add('x', 'j');
        }

        IPEndPoint ip;
        Socket client;
        const int Port = 2302;

        void MoKetNoi()
        {
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(ip);
                if (KiemTraTenDangNhap())
                    client.Send(XuLyDuLieuDi(MaHoaChuoi("[" + txtTenDangNhap.Text + "]")));
            }
            catch
            {
                ThemCauChat("không thể kết nối đến sever");
                return;
            }
            Thread listen = new Thread(NhanTinVe);
            listen.IsBackground = true;
            listen.Start();

        }

        private bool KiemTraTenDangNhap()
        {
            var ten = txtTenDangNhap.Text.ToCharArray();
            foreach (var item in ten)
            {
                if (item == ']' || item == '[' || item == '*')
                {
                    ThemCauChat("kết nối không thành công xem lại tên đăng nhập");
                    KhungChat.BackColor = Color.Red;
                    return false;
                }
            }
            KhungChat.BackColor = Color.White;
            return true;
        }




        void DongKetNoi()
        {
            if (client == null)
                return;
            btnConnect.Enabled = true;
            client.Close();
            ThemCauChat("đã tắt kết nối hiện tại có thể mở kết nối khác");
        }

        void GuiTinDi(string chuoi)
        {
            client.Send(XuLyDuLieuDi(MaHoaChuoi(chuoi)));
        }

        void NhanTinVe()
        {
            try
            {
                while (true)
                {
                    var data = new byte[1024];
                    client.Receive(data);

                    string cauChat = XuLyDuLieuDen(data);
                    kiemTraCauChat(cauChat);

                }
            }
            catch
            {
                client.Close();
            }
        }

        private void kiemTraCauChat(string cauChat)
        {
            var cau = cauChat.Split('/');
            if (cau[0] == "**")
            {
                if (cau.Length == 1)
                    ThemCauChat("không có người nhận tin " + txtNguoiNhan.Text);
                else if (cau.Length == 2)
                    ThemCauChat(cau[1] + " : không có kết nối trên sever");
            }
            else if (cauChat == "[]")
                ThemCauChat("kết nối thành công tới sever");
            else if (cauChat == "[[]")
                ThemCauChat("sever không có ai");
            else if (cauChat == "[]]")
                ThemCauChat("kết nối không thành công tên đã bị trùng trên sever");
            else ThemCauChat(cauChat);
        }

        void ThemCauChat(string cauChat)
        {
            KhungChat.Items.Add(cauChat);
            txtCauChat.Clear();
        }

        byte[] XuLyDuLieuDi(object obj)
        {
            var stream = new MemoryStream();
            var formater = new BinaryFormatter();
            formater.Serialize(stream, obj);
            return stream.ToArray();
        }

        string XuLyDuLieuDen(byte[] data)
        {
            var stream = new MemoryStream(data);
            var formater = new BinaryFormatter();
            var chuoiChuaGiaiMa = (string)formater.Deserialize(stream);
            return MaHoaChuoi(chuoiChuaGiaiMa);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DongKetNoi();
        }

        private string MaHoaChuoi(string chuoiVao)
        {
            var chuoi = chuoiVao.ToCharArray();
            var chuoiDuocMaHoa = "";
            foreach (char item in chuoi)
                chuoiDuocMaHoa += LayKetQuaMaHoa(item);
            return chuoiDuocMaHoa;
        }

        private char LayKetQuaMaHoa(char item)
        {
            foreach (var kieuMaHoa in bangMaHoa)
            {
                if (kieuMaHoa.Key == item)
                    return kieuMaHoa.Value;
                else if (kieuMaHoa.Value == item)
                    return kieuMaHoa.Key;
            }
            return item;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                ThemCauChat("chưa kết nối đến server");
                KhungChat.BackColor = Color.Red;
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtCauChat.Text))
            {
                KhungChat.BackColor = Color.Red;
                ThemCauChat("không được tin nhắn trống");
            }
            else
            {
                if (txtNguoiNhan.Text == "tất cả mọi người" || string.IsNullOrWhiteSpace(txtNguoiNhan.Text))
                    GuiTinDi("[@/*" + "@]" + txtCauChat.Text);
                else GuiTinDi("[@" + txtNguoiNhan.Text + "@]" + txtCauChat.Text);
                KhungChat.BackColor = Color.White;
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                ThemCauChat("Nhập tên đăng nhập");
                KhungChat.BackColor = Color.Red;
                return;
            }
            MoKetNoi();
            btnConnect.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DongKetNoi();
        }
        string cauChat;
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = ofd.FileName;

                txtCauChat.Text = DocFile(fileName);
            }
        }

        string DocFile(string pathFile)
        {
            if (!File.Exists(pathFile))
                throw new Exception("lỗi");
            var allLines = File.ReadAllText(pathFile);
            return allLines;
        }
    }
}
