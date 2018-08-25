using Chatlib.MessagerModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Chatlib
{
    public class TryConvertObject
    {
        /// <summary>
        /// chuyển từ obj sang kiểu byte[]
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] SwithToBinnary(object obj)
        {
            var stream = new MemoryStream();
            var formater = new BinaryFormatter();
            formater.Serialize(stream, obj);
            return stream.ToArray();
        }

        /// <summary>
        /// chuyển kiểu byte[] sang messagerbase
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static MessageBaser SwithToMessager(byte[] data)
        {
            var stream = new MemoryStream(data);
            var formatter = new BinaryFormatter();
            return (MessageBaser)formatter.Deserialize(stream);
        }
    }
}
