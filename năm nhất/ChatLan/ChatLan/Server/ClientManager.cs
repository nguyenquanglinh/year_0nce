using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{

    public class ClientManager
    {

        private static ClientManager instance = new ClientManager();

        public static ClientManager Instance { get { return instance; } }

        private ClientManager()
        {

        }

        List<MayKhach> dsMayKhach = new List<MayKhach>();

        public bool IsExist(string name)
        {
            return dsMayKhach.Any(x => x.TenMay == name);
        }

        public void Add(MayKhach client)
        {
            dsMayKhach.Add(client);
        }

        public void Remove(MayKhach client)
        {
            client.Dispose();
            dsMayKhach.Remove(client);
        }

        public MayKhach Get(string name)
        {
            return dsMayKhach.First(x => x.TenMay == name);
        }

        internal IEnumerable<MayKhach> GetAll()
        {
            return this.dsMayKhach;
        }
    }
}
