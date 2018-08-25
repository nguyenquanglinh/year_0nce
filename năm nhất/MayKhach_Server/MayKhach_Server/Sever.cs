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

namespace MayKhach_Server
{
    public class MayChu
    {
        public MayChu()
        {
            Connect();
        }

        IPEndPoint ip;

        Socket Sever;
        List<MayKhach> dsMayKhach;
        const int Port = 2302;

        void Connect()
        {
            dsMayKhach = new List<MayKhach>();
            ip = new IPEndPoint(IPAddress.Any, Port);
            Sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            Sever.Bind(ip);
            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Sever.Listen(100);
                        var client = Sever.Accept();
                        var mayKhach = new MayKhach(client);



                        Thread receive = new Thread(NhanTinVe);
                        receive.IsBackground = true;
                        receive.Start(mayKhach);
                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, Port);
                    Sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }

        void NhanTinVe(object obj)
        {
            var mayNhan = obj as MayKhach;
            if (mayNhan == null)
                return;
            try
            {
                while (true)
                {
                    var data = new byte[1024];
                    mayNhan.SocKet.Receive(data);
                    string chuoi = XuLyTinDen(data);
                    PhanLuongCauChat(chuoi, mayNhan);
                }
            }
            catch
            {
                TatMayNhanTin(mayNhan);
            }
        }

        void TatMayNhanTin(MayKhach mayNhan)
        {
            dsMayKhach.Remove(mayNhan);
            mayNhan.SocKet.Close();
        }
        bool KiemTraTenMayTrenServer(string ten)
        {
            foreach (var item in dsMayKhach)
            {
                if (item.TenMay == ten)
                    return false;
            }
            return true;
        }

        private void PhanLuongCauChat(string chuoi, MayKhach mayNhan)
        {
            var tenMayKhach = LayTenMayKhachTrenServer(chuoi);
            if (mayNhan.TenMay == null)
            {
                if (KiemTraTenMayTrenServer(tenMayKhach))
                {
                    dsMayKhach.Add(mayNhan);
                    mayNhan.TenMay = tenMayKhach;
                    mayNhan.SocKet.Send(XuLuTinDi("[]"));
                }
                else if (dsMayKhach.Count == 1)
                    dsMayKhach[0].SocKet.Send(XuLuTinDi("[[]"));
                else
                {
                    mayNhan.SocKet.Send(XuLuTinDi("[]]"));
                    TatMayNhanTin(mayNhan);
                }
            }
            else if (KiemTraTenMayNhan(tenMayKhach))
            {
                var cauGui = LayCauChatDen(chuoi, tenMayKhach);
                var DsTenMayNhan = tenMayKhach.Remove(0, 1);
                DsTenMayNhan = DsTenMayNhan.Remove(DsTenMayNhan.Length - 1, 1);
                if (DsTenMayNhan == "/*")
                {
                    ChuyenTin(cauGui, dsMayKhach, mayNhan.TenMay);
                    return;
                }
                var ten = DsTenMayNhan.Split('&');
                var nhomChat = new List<MayKhach>();
                nhomChat.Add(mayNhan);
                foreach (var item in ten)
                {
                    var tenMayGui = LayMayKhachTuongUng(item);
                    if (tenMayGui != null)
                        nhomChat.Add(tenMayGui);
                    else
                        mayNhan.SocKet.Send(XuLuTinDi("**/" + item));
                }
                ChuyenTin(cauGui, nhomChat, mayNhan.TenMay);
            }
            else
            {
                TatMayNhanTin(mayNhan);
                throw new Exception("lỗi");
            }
        }

        private bool KiemTraTenMayNhan(string chuoi)
        {
            if (chuoi[0] == '@' && chuoi[chuoi.Length - 1] == '@')
                return true;
            return false;
        }

        string LayTenMayKhachTrenServer(string cauChat)
        {
            var tpChat = cauChat.ToCharArray();
            var tenMay = "";
            for (int i = 1; i < tpChat.Length; i++)
            {
                if (tpChat[0] == '[' && tpChat[i] != ']')
                    tenMay += tpChat[i];
                else break;
            }
            return tenMay;
        }

        string LayCauChatDen(string chuoi, string tenMay)
        {
            if (tenMay.Length < 1)
                throw new Exception("lỗi");
            int chiSo = tenMay.Length + 2;
            var cauChat = "";
            for (int i = chiSo; i < chuoi.Length; i++)
            {
                cauChat += chuoi[i];
            }
            return cauChat;
        }

        MayKhach LayMayKhachTuongUng(string tenMay)
        {
            foreach (var item in dsMayKhach)
            {
                if (item.TenMay == tenMay)
                    return item;
            }
            return null;
        }

        byte[] XuLuTinDi(object obj)
        {
            var stream = new MemoryStream();
            var formater = new BinaryFormatter();
            formater.Serialize(stream, obj);
            return stream.ToArray();
        }

        string XuLyTinDen(byte[] data)
        {
            var stream = new MemoryStream(data);
            var formater = new BinaryFormatter();
            return (string)formater.Deserialize(stream);
        }

        private void ChuyenTin(string cauChat, List<MayKhach> dsMayChatChung, string tenMay)
        {
            foreach (var may in dsMayChatChung.ToArray())
            {
                may.SocKet.Send(XuLuTinDi(tenMay + " : " + cauChat));
            }

        }

    }
}
