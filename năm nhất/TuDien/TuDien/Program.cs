using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDien
{
    public class Program
    {

        public static Dictionary<string, int> KiemTraSoChuSoDong(string s)
        {
            Dictionary<string, int> a = new Dictionary<string, int>();

            var allWord = s.Split(' ');

            foreach (var item in s.Split(' '))
            {
                if (!a.ContainsKey(item))
                    a.Add(item, 1);
                else
                    a[item] = a[item] + 1;
            }

            return a;
        }

        static void Main(string[] args)
        {
            var chuoi = File.ReadAllText("C:\\abc.txt");
            var kq = KiemTraSoChuSoDong(chuoi);
            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }
            var s = "";
            StreamWriter linh;
            linh = File.CreateText("linh.text");
            while (true)
            {
                Console.Write("viet du lieu can ghi");
                s = Console.ReadLine();
                if (s.Length != 0)
                    linh.WriteLine(s);
                else
                    break;
            }
            linh.Close();



            Console.Write("Nhap ten file ban dau: ");
            string fileName = Console.ReadLine();
            Console.Write("Nhap ten file 2: ");
            string fileName1 = Console.ReadLine();
            if (File.Exists(fileName))
            {
                StreamReader file1 = File.OpenText(fileName);
                StreamWriter file2 = File.CreateText(fileName1);
               
               while(true)
                {
                    var q    = file1.ReadLine();
                    if (s != null)
                        file2.WriteLine(q.ToUpper());
                    else break;
                }
               
                file1.Close();
                file2.Close();
            }







            Console.ReadLine();
        }
    }
}

