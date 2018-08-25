using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatlib.MessagerModel
{
    [Serializable]
    abstract public class MessageBaser
    {
        [NonSerialized]
        public object Client;
        /// <summary>
        /// xử lý tin nhắn được chấp nhận
        /// </summary>
        /// <param name="processor"></param>
        public abstract void Accept(IMessageProcess processor);
        /// <summary>
        /// Tên người gửi
        /// </summary>
        public string NameSender { get; set; }
        /// <summary>
        /// hàm tạo đối tượng tin nhắn
        /// </summary>
        /// <param name="name"></param>
        public MessageBaser(string name)
        {
            this.NameSender = name;
        }
    }

    /// <summary>
    /// đối tượng kết nối server
    /// </summary>
    [Serializable]
    public class ConnectMessageRequest : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public ConnectMessageRequest(string name)
            : base(name)
        {

        }
    }

    /// <summary>
    /// đối tượng kết nối tin nhắn thành công
    /// </summary>
    [Serializable]
    public class ConnectMessageSuccess : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }

        public ConnectMessageSuccess(string name)
            : base(name)
        {

        }
    }
    /// <summary>
    /// đối tượng kết nối tin nhắn thất bại
    /// </summary>
    [Serializable]
    public class ConnecMessageFaile : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public ConnecMessageFaile(string name)
            : base(name)
        {

        }
        public string Exception { get; set; }
    }
    /// <summary>
    /// gửi tin nhắn
    /// </summary>
    [Serializable]
    public class SendMessage : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SendMessage(string name, string sendTo, string message)
            : base(name)
        {
            this.Message = message;
            this.SendTo = sendTo;
        }
        public string SendTo { get; set; }
        public string Message { get; set; }

    }
    /// <summary>
    /// gửi tọa độ đi
    /// </summary>
    [Serializable]
    public class SendLocationPlayerClick : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SendLocationPlayerClick(string name, int x, int y)
            : base(name)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }

    [Serializable]
    public class RecieveLoactionPlayerClick : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public RecieveLoactionPlayerClick(string name, int x, int y)
            : base(name)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }



    /// <summary>
    /// nhận tin nhắn
    /// </summary>
    [Serializable]
    public class RecievedMessage : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public string Form { get; set; }

        public RecievedMessage(string name, string mesage)
            : base(name)
        {
            this.Message = mesage;
        }

        public string Message { get; set; }

    }


    [Serializable]
    public class ReceiFileBig : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public ReceiFileBig(string name, string fileName, string sendTo, List<byte[]> data)
            : base(name)
        {
            this.FileName = fileName;
            this.SendTo = sendTo;
            this.BigData = data;
        }


        public string FileName { get; set; }

        public List<byte[]> BigData { get; set; }

        public string SendTo { get; set; }
    }

    /// <summary>
    /// gửi tin nhắn lỗi
    /// </summary>
    [Serializable]
    public class SendMessageFalse : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SendMessageFalse(string name, string message, string exception)
            : base(name)
        {
            this.Message = message;
            this.Exception = exception;
        }

        public string Message { get; set; }

        public string Exception { get; set; }

    }
    [Serializable]
    public class SendFileBig : MessageBaser
    {
        public SendFileBig(string name, string sendTo, string fileName, int soFile)
            : base(name)
        {
            this.SoFile = soFile;
            this.SendTo = sendTo;
            this.FileName = fileName;
        }

        public SendFileBig(string stt, byte[] data)
            : base(stt)
        {
            DaTaBig.Add(data);
        }

        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }

        public List<byte[]> DaTaBig = new List<byte[]>();

        public string SendTo { get; set; }

        public string FileName { get; set; }

        public int SoFile { get; set; }

        public byte[] DaTa { get; set; }
    }

    /// <summary>
    /// gửi tin nhắn
    /// </summary>
    [Serializable]
    public class SenFile : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SenFile(string name, byte[] data, string sendTo, string fileName)
            : base(name)
        {
            this.FileName = fileName;
            this.ByteData = data;
            this.SendTo = sendTo;
        }

        public byte[] ByteData { get; set; }

        public string SendTo { get; set; }

        public string FileName { get; set; }
    }
    /// <summary>
    /// nhận tin nhắn
    /// </summary>i
    [Serializable]
    public class RecievedFile : MessageBaser
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        //bỏ send to
        public RecievedFile(string name, string sendTo, string fileName, byte[] data)
            : base(name)
        {
            this.SendTo = sendTo;
            this.FileName = fileName;
            this.ByteData = data;
        }

        public byte[] ByteData { get; set; }

        public string FileName { get; set; }

        public string SendTo { get; set; }
    }


}
