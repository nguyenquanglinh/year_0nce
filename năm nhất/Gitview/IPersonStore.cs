using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gitview
{
    interface IPersonStore
    {
        List<Nguoi> LoadAll();
        void SaveAll(List<Nguoi> listNguoi);
        void SaveOne(Nguoi nguoi);
    }

    class FileStore : IPersonStore
    {
        public string Path { get; set; } = "data.txt";

        public List<Nguoi> LoadAll()
        {
            List<Nguoi> dsNguoi = new List<Nguoi>();
            
            if (!File.Exists(Path))
                MessageBox.Show("file không tồn tại");
            else
            {
                 var z = File.ReadAllLines(Path);
                    for (int i = 0; i < z.Length; i++)
                    {
                        var x = z[i].Split(',');
                        var ten = x[0];
                        var tuoi = x[1];
                        var gioiTinh = x[2];
                        var diaChi = x[3];
                        Nguoi nguoi = new Nguoi(ten, tuoi, gioiTinh, diaChi);
                        dsNguoi.Add(nguoi);
                    }
                }
            return dsNguoi;
        }

        public void SaveAll(List<Nguoi> listNguoi)
        {
            throw new NotImplementedException();
        }

        public void SaveOne(Nguoi nguoi)
        {
            string appendText = nguoi.ToString() + Environment.NewLine;
            File.AppendAllText(Path, appendText);
        }
    }

    class MongodbStore : IPersonStore
    {
        private MongoClient client;
        private IMongoCollection<Nguoi> collection;
        private IMongoDatabase database;

        public MongodbStore()
        {
            client = new MongoClient(new MongoUrl("mongodb://quang:quang@ds149711.mlab.com:49711/persons"));
            database = client.GetDatabase("persons");
            collection = database.GetCollection<Nguoi>("nguoi");
        }
        public List<Nguoi> LoadAll()
        {
            var all = collection.Find(_ => true).ToList();
            return all;
        }

        public void SaveAll(List<Nguoi> listNguoi)
        {
            throw new NotImplementedException();
        }

        public void SaveOne(Nguoi nguoi)
        {
            collection.InsertOne(nguoi);
        }
    }
}
