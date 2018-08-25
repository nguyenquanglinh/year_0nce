using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamDoiQueue
{
    class Program
    {
        // đọc file
        public static int[,] DocFile()
        {
            string path = "D:\\input.txt";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string fileString = rd.ReadToEnd();
            var xx = fileString.Split('\r');
            var soDinh = int.Parse(xx[0]);
            var arr = new int[soDinh + 1, soDinh + 1];
            for (int i = 1; i < xx.Length; i++)
            {
                if ((xx[i]) != "\n")
                {

                    var dong = xx[i].Split(' ');
                    arr[int.Parse(dong[0]), int.Parse(dong[1])] = 1;
                    arr[int.Parse(dong[1]), int.Parse(dong[0])] = 1;
                }
            }
            rd.Close();
            return arr;
        }
        static void Main(string[] args)
        {
            var arr = DocFile();
            var queue = new Queue<int>();
            queue.Enqueue(1);
           var xx= queue.Dequeue();
           Console.WriteLine(xx);
           Console.ReadLine();
        }
    }
}
