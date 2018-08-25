using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MayKhach
{
    public class Client
    {
        public Client(string tenDangNhap)
        {
            TaoBangMaHoaRieng();
            MoKetNoi(tenDangNhap);

        }
        Dictionary<char, char> bangMaHoa;
        IPEndPoint ip;
        Socket client;
        const int Port = 2302;
        string tenDangNhap;
        void TaoBangMaHoaRieng()
        {
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

        void MoKetNoi(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(ip);
                if (KiemTraTenDangNhap())
                {
                    client.Send(XuLyDuLieuDi(MaHoaChuoi("[" + tenDangNhap + "]")));
                }
            }
            catch
            {
                CoCauChatMoi("không thể kết nối tới server");
                return;
            }
            Thread listen = new Thread(NhanTinVe);
            listen.IsBackground = true;
            listen.Start();

        }

        void DongKetNoi()
        {
            if (client == null)
                return;
            client.Close();
        }

        public void GuiTinDi(string chuoi)
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
                    CoCauChatMoi("không có người nhận tin " + tenDangNhap);
                else if (cau.Length == 2)
                    CoCauChatMoi(cau[1] + " : không có kết nối trên sever");
            }
            else if (cauChat == "[]")
                CoCauChatMoi("kết nối thành công tới sever");
            else if (cauChat == "[[]")
                CoCauChatMoi("sever không có ai");
            else if (cauChat == "[]]")
                CoCauChatMoi("kết nối không thành công tên đã bị trùng trên sever");
            else
                CoCauChatMoi(cauChat);
        }


        private bool KiemTraTenDangNhap()
        {
            var ten = tenDangNhap.ToCharArray();
            foreach (var item in ten)
            {
                if (item == ']' || item == '[' || item == '*')
                {
                    CoCauChatMoi("kết nối không thành công xem lại tên đăng nhập");
                    return false;
                }
            }
            return true;
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

        void CoCauChatMoi(string cauChat)
        {
            if (this.ThemCauChat != null)
                ThemCauChat(cauChat, new EventArgs());
        }

        public event EventHandler ThemCauChat;



    }
}
