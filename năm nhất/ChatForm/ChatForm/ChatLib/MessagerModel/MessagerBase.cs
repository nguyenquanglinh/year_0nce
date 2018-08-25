using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib.MessageModel
{
    [Serializable]
    abstract public class MessageBase  // class 
    {
        [NonSerialized]
        public object Client; // member 
        /// <summary>
        /// xử lý tin nhắn được chấp nhận
        /// 
        /// </summary>
        /// <param name="processor"></param>
        public abstract void Accept(IMessageProcess processor); // abstract method 
        /// <summary>
        /// Tên người gửi
        /// </summary>
        public string NameSender { get; set; }  // properties 
        /// <summary>
        /// hàm tạo đối tượng tin nhắn
        /// </summary>
        /// <param name="name"></param>
        public MessageBase(string name) // constructor
        {
            this.NameSender = name;
        }
    }

    [Serializable]
    public class SendClientClose : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SendClientClose(string name, string from)
            : base(name)
        {
            this.From = from;
        }

        public string From { get; set; }
    }
    [Serializable]
    public class ReceiveClientClose : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public ReceiveClientClose(string name, string from)
            : base(name)
        {
            this.From = from;
        }

        public string From { get; set; }
    }

    /// <summary>
    /// đối tượng kết nối server
    /// </summary>
    [Serializable]
    public class ConnectMessageRequest : MessageBase
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
    //gửi lời mời
    [Serializable]
    public class SendInvation : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SendInvation(string name, string from)
            : base(name)
        {
            this.From = from;
        }

        public string From { get; set; }
    }

    //không đồng ý chơi
    [Serializable]
    public class ReciveInvation : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public ReciveInvation(string name, string from, bool isInvation)
            : base(name)
        {
            this.IsInvation = isInvation;

            this.From = from;
        }

        public string From { get; set; }

        public bool IsInvation { get; set; }
    }
    //đồng ý chơi

    /// <summary>
    /// đối tượng kết nối tin nhắn thành công
    /// </summary>
    [Serializable]
    public class ConnectMessageSuccess : MessageBase
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
    public class ConnecMessageFaile : MessageBase
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
    public class SendMessage : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SendMessage(string name, string sendTo, string message, bool isLoaction)
            : base(name)
        {

            this.Message = message;
            this.SendTo = sendTo;
            this.IsLocation = isLoaction;
        }
        public string SendTo { get; set; }
        public string Message { get; set; }
        public bool IsLocation { get; set; }

    }
    [Serializable]
    public class SendFindPlayer : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SendFindPlayer(string name)
            : base(name)
        {

        }
    }
    [Serializable]
    public class ReceiFindPlayer : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public ReceiFindPlayer(string name, string[] userNamePlayer)
            : base(name)
        {
            this.UserNamePlayer = userNamePlayer;
        }
         
        public string[] UserNamePlayer { get; set; }
    }


    /// <summary>
    /// nhận tin nhắn
    /// </summary>
    [Serializable]
    public class RecievedMessage : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }

        public RecievedMessage(string name, string mesage, bool isLocation)
            : base(name)
        {
            this.Message = mesage;
            this.isLoaction = isLocation;
        }

        public string Message { get; set; }

        public string From { get; set; }

        public bool isLoaction { get; set; }
    }



    /// <summary>
    /// gửi tin nhắn lỗi
    /// </summary>
    [Serializable]
    public class SendMessageFalse : MessageBase
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
    public class SendFileBig : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SendFileBig(string name, string from, string fileName, byte[] data)
            : base(name)
        {
            this.From = from;
            this.FileName = fileName;
            this.Data = data;
        }

        public string From { get; set; }

        public string FileName { get; set; }

        public byte[] Data { get; set; }
    }

    /// <summary>
    /// gửi tin nhắn
    /// </summary>
    [Serializable]
    public class SendFile : MessageBase
    {
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
        public SendFile(string name, byte[] data, string sendTo, string fileName)
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
    public class RecievedFile : MessageBase
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
