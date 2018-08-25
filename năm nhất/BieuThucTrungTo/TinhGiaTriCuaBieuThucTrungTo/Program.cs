using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
namespace TinhGiaTriCuaBieuThucTrungTo
{
    class Program
    {
        //kiem tra chuoi vua nhap co dung k-ok
        static bool KiemTraChuoiVuaNhap(char[] mangChar)
        {
            int mo = 0, dong = 0;
            for (int i = 0; i < mangChar.Length; i++)
            {
                if (mangChar[i] == '(')
                    mo++;
                if (mangChar[i] == ')')
                    dong++;
                if (mo < dong)
                    return false;
            }
            return mo - dong == 0;
        }

        //kiểm tra toán tử +-*/%^!
        static bool KiemTraToanTu(char Char)
        {
            if (Char == '+' || Char == '-' || Char == '*' || Char == '/' || Char == '%' || Char == '^' || Char == '!')
                return true;
            return false;
        }

        //kiem tra số tự nhiên
        static bool kiemTraSoTuNhien(char Char)
        {
            if (Char == '9' || Char == '8' || Char == '7' || Char == '6' || Char == '5' || Char == '4' || Char == '3' || Char == '2' || Char == '1' || Char == '0')
                return true;
            return false;
        }

        // so sánh độ ưu tiên toán tử
        static int SoSanhToanTu(char Char)
        {
            if (Char == '%' || Char == '^')
                return 3;
            if (Char == '*' || Char == '/')
                return 2;
            if (Char == '+' || Char == '-')
                return 1;
            return 0;
        }

        //Ghi flie
        static void GhiFile(string s)
        {
            string path = "D:\\datangay2.txt";
            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
            writer.WriteLine(s);
            writer.Flush();
            fs.Close();
        }
        // đọc file
        static string DocFile(string path)
        {
            path = "D:\\data.txt";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string dong = rd.ReadToEnd();
            rd.Close();
            return dong;
        }

        static void Main(string[] args)
        {
            char[] mangChar;


            //Console.Write("Nhap bieu thuc can tinh ");
            string s = DocFile("D:\\data.text");
            var list = new List<string>();
            foreach (var item in s.Split('\n'))
            {
                list.Add(item);

                mangChar = new char[item.Length];
                mangChar = item.ToCharArray();


                //  while (!KiemTraChuoiVuaNhap(mangChar));

                var stack = new Stack<object>();
                var kq = "";
                foreach (var s1 in mangChar)
                {
                    if (kiemTraSoTuNhien(s1))
                        kq += s1 + " ";
                    else if (s1 == '(')
                        stack.Push(s1);
                    else if (s1 == ')')
                    {
                        var kqTrongStack = stack.Pop();
                        while ((char)kqTrongStack != '(')
                        {
                            kq += kqTrongStack;
                            kqTrongStack = stack.Pop();
                        }
                    }
                    else if (KiemTraToanTu(s1))
                    {

                        while (stack.Count > 0 && SoSanhToanTu(s1) <= SoSanhToanTu((char)stack.Peek()))
                        {
                            kq += stack.Pop();
                        }
                        stack.Push(s1);
                    }
                }
                while (stack.Count > 0)
                {
                    kq += stack.Pop() + " ";
                }

                Console.WriteLine(kq);
                foreach (var s2 in kq.ToCharArray())
                {
                    if (s2 == ' ')
                        continue;
                    else if (kiemTraSoTuNhien(s2))
                        stack.Push(s2);
                    else if (KiemTraToanTu(s2))
                    {
                        if (s2 == '+')
                        {
                            int x1 = int.Parse(stack.Pop().ToString());
                            int x2 = int.Parse(stack.Pop().ToString());
                            int x3 = x1 + x2;
                            stack.Push(x3);
                        }
                        else if (s2 == '-')
                        {
                            int x1 = int.Parse(stack.Pop().ToString());
                            int x2 = int.Parse(stack.Pop().ToString());
                            int x3 = x2 - x1;
                            stack.Push(x3);
                        }
                        else if (s2 == '*')
                        {
                            int x1 = int.Parse(stack.Pop().ToString());
                            int x2 = int.Parse(stack.Pop().ToString());
                            int x3 = x1 * x2;
                            stack.Push(x3);
                        }
                        else if (s2 == '/')
                        {
                            int x1 = int.Parse(stack.Pop().ToString());
                            int x2 = int.Parse(stack.Pop().ToString());
                            int x3 = x1 / x2;
                            stack.Push(x3);
                        }
                        else if (s2 == '%')
                        {
                            int x1 = int.Parse(stack.Pop().ToString());
                            int x2 = int.Parse(stack.Pop().ToString());
                            int x3 = x2 % x1;
                            stack.Push(x3);
                        }
                        else
                        {
                            int x1 = int.Parse(stack.Pop().ToString());
                            int x2 = int.Parse(stack.Pop().ToString());
                            double x3 = Math.Pow(x2, x1);
                            stack.Push(x3);
                        }
                    }
                }
                var kq1 = item + "=" + stack.Pop().ToString();
                GhiFile(kq1);
            }
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
