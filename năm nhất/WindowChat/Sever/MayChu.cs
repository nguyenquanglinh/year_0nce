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

namespace Sever
{
    public partial class MayChu : Form
    {
        public MayChu()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        IPEndPoint ip;

        Socket Sever;
        List<Socket> cacMayKhach;
        const int Port = 2302;
        string cauChat;

        void Connect()
        {
            cacMayKhach = new List<Socket>();
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
                        cacMayKhach.Add(client);
                        Thread receive = new Thread(NhanTinVe);
                        receive.IsBackground = true;
                        receive.Start(client);
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

        void DongKetNoi()
        {
            if (Sever == null)
                return;
            Sever.Close();
        }

        void GuiTinDi(Socket mayGui, string cauChat)
        {
            if (cauChat != null)
                mayGui.Send(XuLuTinDi(cauChat));
            else MessageBox.Show("tin rong");
        }

       

        void NhanTinVe(object obj)
        {
            var mayNhan = obj as Socket;
            if (mayNhan == null)
                return;
            try
            {
                while (true)
                {
                    var data = new byte[1024];
                    mayNhan.Receive(data);
                    cauChat = XuLyTinDen(data);

                    ThemCauChat(cauChat);
                    ChuyenTin();
                }
            }
            catch
            {
                cacMayKhach.Remove(mayNhan);
                mayNhan.Close();
            }
        }

        void ThemCauChat(string cauChat)
        {
            KhungChat.Items.Add(cauChat);
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

        private void MayChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DongKetNoi();
        }

        private void ChuyenTin()
        {
            foreach (var mayKhach in cacMayKhach)
            {
                GuiTinDi(mayKhach, cauChat);
            }
            cauChat = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}
