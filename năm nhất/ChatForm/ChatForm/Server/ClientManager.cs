using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientManager
    {
        static ClientManager instance = new ClientManager();

        List<MayKhach> dsMayKhach = new List<MayKhach>();
        /// <summary>
        /// bảng ds máy khách
        /// </summary>
        public static ClientManager Instance { get { return instance; } }

        /// <summary>
        /// kiểm tra tên máy đã có trên ds máy khách
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsCounterName(string name)
        {
            return dsMayKhach.Any(x => x.TenMay == name);
        }


        /// <summary>
        /// thêm 1 máy khách khác vào danh sách máy khách
        /// </summary>
        /// <param name="client"></param>
        public void Add(MayKhach client)
        {
            dsMayKhach.Add(client);
        }
        /// <summary>
        /// đóng máy khách và xóa khỏi danh sách máy khách
        /// </summary>
        /// <param name="client"></param>
        public void Remove(MayKhach client)
        {
            client.Dispose();
            dsMayKhach.Remove(client);
        }
        /// <summary>
        /// lấy tất cả các máy có tên ==name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public MayKhach Get(string name)
        {
            return dsMayKhach.First(x => x.TenMay == name);
        }

        public string[] GetUserPlayerNew(string name)
        {
            return dsMayKhach.Select(x => x.TenMay).ToArray();
        }
        /// <summary>
        /// lấy tất cả danh sách máy khách
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MayKhach> GetAll()
        {
            return dsMayKhach;
        }
    }
}
