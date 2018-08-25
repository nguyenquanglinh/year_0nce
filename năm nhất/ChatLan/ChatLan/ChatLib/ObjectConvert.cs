using ChatLib.MessageModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    /// <summary>
    /// Lớp này để chuyển đối object và mảng byte để truyền đi.
    /// </summary>
    public static class ObjectConvert
    {
        /// <summary>
        /// Chuyển 1 đối tượng thành mảng byte
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] Object2Binary(object obj)
        {
            var stream = new MemoryStream();
            var formater = new BinaryFormatter();
            formater.Serialize(stream, obj);
            return stream.ToArray();
        }

        /// <summary>
        /// Chuyển mảng byte thành đối tượng
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static MessageBase Binnary2Object(byte[] data)
        {
            var stream = new MemoryStream(data);
            var formater = new BinaryFormatter();
            return (MessageBase)formater.Deserialize(stream);
        }

    }
}
