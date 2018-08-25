using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib.MessageModel
{
    /// <summary>
    /// Đổi tượng message cho phần mềm chat,
    ///  Tất các gói tin đều sẽ được gửi theo đối tượng kế thừa từ đối tượng này 
    /// </summary>
    [Serializable]
    abstract public class MessageBase
    {

        [NonSerialized]
        public object Client;

        /// <summary>
        /// Xử lý message bởi processor
        /// </summary>
        /// <param name="processor"></param>
        /// <returns></returns>
        public abstract void Accept(IMessageProcess processor);

        /// <summary>
        /// Tên người gửi
        /// </summary>
        public string Sender { get; set; }

        public MessageBase(string name)
        {
            this.Sender = name;
        }
    }
    /// <summary>
    /// Gói tin báo đã connect kèm theo tên
    /// </summary>
    [Serializable]
    public class ConnectMessageRequest : MessageBase
    {
        public ConnectMessageRequest(string name)
            : base(name)
        {
        }

        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }


       
    }
    /// <summary>
    /// Gói tin báo connect kèm theo tên
    /// </summary>
    [Serializable]
    public class ConnectMessageSuccess : MessageBase
    {
        public ConnectMessageSuccess(string name)
            : base(name)
        {

        }
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }

    }
    /// <summary>
    /// Gói tin báo đã connect lỗi 
    /// </summary>
    [Serializable]
    public class ConnectMessageFailed : MessageBase
    {
        /// <summary>
        /// Chi tiết lỗi
        /// </summary>
        public string Reason { get; set; }

        public ConnectMessageFailed(string name)
            : base(name)
        {

        }
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
    }
    /// <summary>
    /// Gửi ti nhắn đến cho người khác 
    /// </summary>
    [Serializable]
    public class SendMessage : MessageBase
    {
        /// <summary>
        /// Người nhận 
        /// </summary>
        public string To { get; set; }
        /// <summary>
        /// Tin nhắn
        /// </summary>
        public string Message { get; set; }

        public SendMessage(string name, string to, string message)
            : base(name)
        {
            this.Message = message;
            this.To = to;
        }
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
    }
    /// <summary>
    /// Gửi ti nhắn đến cho người khác 
    /// </summary>
    [Serializable]
    public class RecievedMessage : MessageBase
    {
        /// <summary>
        /// Người nhận 
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Tin nhắn
        /// </summary>
        public string Message { get; set; }

        public RecievedMessage(string name, string message)
            : base(name)
        {
            this.Message = message;
        }
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
    }
    /// <summary>
    /// Gửi ti nhắn đến cho người khác 
    /// </summary>
    [Serializable]
    public class SendMessageFailed : MessageBase
    {
        /// <summary>
        /// Người nhận 
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Tin nhắn
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Tin nhắn
        /// </summary>
        public string Reason { get; set; }


        public SendMessageFailed(string name, string message, string reason)
            : base(name)
        {
            this.Message = message;
            this.Reason = reason;
        }
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
    }
    /// <summary>
    /// Gửi ti nhắn đến cho người khác 
    /// </summary>
    [Serializable]
    public class SendFile : MessageBase
    {
        /// <summary>
        /// Người nhận 
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Tin nhắn
        /// </summary>
        public byte[] ByteData { get; set; }
        /// <summary>
        /// Người nhận 
        /// </summary>
        public string FileName { get; set; }

        public SendFile(string name, string to, byte[] data, string fileName)
            : base(name)
        {
            this.FileName = fileName;
            this.ByteData = data;
            this.To = to;
        }
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
    }
    /// <summary>
    /// Gửi ti nhắn đến cho người khác 
    /// </summary>
    [Serializable]
    public class RecievedFile : MessageBase
    {
        /// <summary>
        /// Người nhận 
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Người nhận 
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Người nhận 
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Tin nhắn
        /// </summary>
        public byte[] ByteData { get; set; }

        public RecievedFile(string name, string to, byte[] data, string fileName)
            : base(name)
        {
            this.FileName = fileName;
            this.To = to;
            this.ByteData = data;
        }
        public override void Accept(IMessageProcess processor)
        {
            processor.Process(this);
        }
    }
}
