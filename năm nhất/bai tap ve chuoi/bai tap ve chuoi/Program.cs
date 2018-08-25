using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_ve_chuoi
{
    class Program
    {
        //public static string test(string s)
        //{
        //    if (String.IsNullOrEmpty(s))
        //        return s;

        //    string result = "";

        //    //lấy danh sách các từ  

        //    string[] words = s.Split(' ');

        //    foreach (string word in words)
        //    {
        //        // từ nào là các khoảng trắng thừa thì bỏ  
        //        if (word.Trim() != "")
        //        {
        //            if (word.Length > 1)
        //                result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
        //            else
        //                result += word.ToUpper() + " ";
        //        } foreach (var item in s.Split())
        //            {
        //                Console.Write("  " + item.ToUpper());
        //                //Console.WriteLine();
        //                foreach(var chudau in item.Split(' '))
        //                {
        //                    Console.Write(chudau);
        //                }
        //}

        //    }
        //    return result.Trim();
        //}

        static void Main(string[] args)
        {
            Console.Write("nhap chuoi ");
            string s = Console.ReadLine();
            //int l = 0; 
            //Console.Write("In tung ky tu trong chuoi ban dau: ");
            //while (l <= s.Length - 1)
            //{
            //    Console.Write("{0} ", s[l]);
            //    l++;
            //}
            //Console.Write("\n\n");
            //////int[] a = new int[s.Length];
            //cau b
            //for (int i = 0; i <= s.Length+1; i++)
            //{
            //    int j = i + 1;
            //    if (s[i] == '.')
            //    {


            //       var s2=s.ToUpper().Substring(s[i+1], 1) + s.Remove(s[i+1], 1);
            //    }
            //}
            // Console.WriteLine("   "+s.Remove(0, 1));
            //cau a 2 dong
            //var s1 = s.ToUpper().Substring(0, 1);
            //Console.WriteLine("cau a "+s1 + s.Remove(0, 1));
            ////{
            ////    Console.Write(s.Substring(1).ToUpper() + " " + item);
            ////}

            var a = s.Split();
            foreach (var item in s.Split())
            {
                Console.Write("item" + item);
                Console.Write("trim" + item.Trim());
                //KD  Console.Write(item + " ");



                Console.ReadLine();
            }
        }
    }
}
