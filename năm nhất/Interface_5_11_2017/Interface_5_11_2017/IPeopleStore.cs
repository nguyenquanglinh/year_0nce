using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_5_11_2017
{

    interface IPeopleStore
    {
        List<Nguoi> LoadAll();
        void SaveAll(List<Nguoi> listNguoi);
    }

    class PeopleStore : IPeopleStore
    {

        public string Path { get; set; } = "data.txt";

        public List<Nguoi> LoadAll()
        {
            List<Nguoi> listPeople = new List<Nguoi>();
            if (!File.Exists(Path))
                MessageBox.Show("file không tồn tại");
            else
            {
                var z = File.ReadAllLines(Path);
                for (int i = 0; i < z.Length; i++)
                {
                    var pepple = new Nguoi();
                    var x = z[i].Split(',');
                    pepple.Name = x[0];
                    pepple.Age = x[1];
                    pepple.Gender = x[3];
                    pepple.Address = x[2];
                    listPeople.Add(pepple);
                }
            }
            return listPeople;
        }

        public void SaveAll(List<Nguoi> listNguoi)
        {
            File.Delete(Path);
            foreach (var item in listNguoi)
            {
                string appendText = item.ToString() + Environment.NewLine;
                File.AppendAllText(Path, appendText);
            }
        }
    }

    class Memory : IPeopleStore
    {
        List<Nguoi> listPeople = new List<Nguoi>();
        public List<Nguoi> LoadAll()
        {
            return listPeople;
        }

        public void SaveAll(List<Nguoi> listNguoi)
        {
            listPeople = listNguoi;
        }
    }

}

