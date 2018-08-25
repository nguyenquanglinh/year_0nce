using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQuyTongLonNhat
{

    class TongMax
    {
        private List<Point> path = new List<Point>();
        private List<Point> pathMax = new List<Point>();

        private int N { get { return Arr.GetLength(1); } }
        private int M { get { return Arr.GetLength(0); } }

        public TongMax(int[,] arr)
        {
            this.Arr = arr;
        }

        public void TimDuong(int i, int j)
        {
            if (Arr[i, j] == 0)
                return;
            path.Add(new Point(j, i));
            Arr[i, j] = 0; // xóa điểm hiển tại để ko duyệt lại điểm đã duyệt
            if (j + 1 < N && Arr[i, j + 1] == 1) // Điểm bên phải điểm đang xét = 1
                TimDuong(i, j + 1);
            if (j - 1 >= 0 && Arr[i, j - 1] == 1) // điêm bên trái =1
                TimDuong(i, j - 1);
            if (i + 1 < M && Arr[i + 1, j] == 1) // điêm bên dưới =1
                TimDuong(i + 1, j);
            if (i - 1 >= 0 && Arr[i - 1, j] == 1) // điêm bên trên =1
                TimDuong(i - 1, j);
            Arr[i, j] = 1; // gán lại điểm =1 sau khi duyệt xong

            if (path.Count > pathMax.Count) // co duong di lon hon 
            {
                pathMax = path.ToList();
                Console.WriteLine(pathMax.Count);
            }

            path.RemoveAt(path.Count - 1);
        }



        public int[,] Arr { get; set; }
    }


    class Program
    {
        static int[,] DocFile(string tenFile)
        {
            string path1 = "D:\\" + tenFile;
            FileStream fs = new FileStream(path1, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);

            string dong = rd.ReadLine();
            var xx = dong.Split(',');
            int hang = 0;
            var arr = new int[int.Parse(xx[0]), int.Parse(xx[1])];
            while (true)
            {
                dong = rd.ReadLine();
                if (dong == null)
                    break;
                xx = dong.Split(',');
                if (hang >= arr.GetLength(0))
                    throw new Exception("lỗi");
                for (int i = 0; i < xx.Length; i++)
                {
                    arr[hang, i] = int.Parse(xx[i]);
                }
                hang++;

            }

            rd.Close();
            return arr;
        }

        //static void GhiFile(string tenFile, List<Diem> list)
        //{
        //    string path = "D:\\" + tenFile;
        //    var s = "";
        //    foreach (var item in list)
        //    {
        //        s = s + item + "=>";
        //    }
        //    if (list.Count > 0)
        //        s = s.Remove(s.Length - 2, 2);
        //    string appendText = s + Environment.NewLine;
        //    File.AppendAllText(path, appendText);
        //}


        static void Main(string[] args)
        {
            var arr = DocFile("arr6.txt");
            var tongMax = new TongMax(arr);
            tongMax.TimDuong(0, 0);

            Console.WriteLine();
            Console.ReadKey();
        }

    }
}

