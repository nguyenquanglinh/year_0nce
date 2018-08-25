using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChuChay
{
    class Program
    {
        static void Main(string[] args)
        {

            ThuChuoi();

            var str = "          cong hoa xa hoi chu nghia viet nam           ";

            while (true)
            {
                Console.Clear();
                Console.CursorTop = 10;
                Console.WriteLine(str);
                str = str.Last() + str.Substring(0, str.Length - 1);
                Thread.Sleep(100);
            } 
        }

        private static void ThuChuoi()
        {
            var s1 = "cong hoa xa hoi chu nghia viet nam";

            var s2 = (string)s1.Clone();// copy thanh 1 chuoi moi
            Console.WriteLine("chuoi copy :" + s2);


            Console.WriteLine("compare to:  cong hoa xa hoi chu nghia viet nam abc : " + s1.CompareTo("cong hoa xa hoi chu nghia viet nam abc"));
            Console.WriteLine("compare to:  cong hoa xa hoi chu nghia viet na: " + s1.CompareTo("cong hoa xa hoi chu nghia viet na"));
            Console.WriteLine("compare to:  cong hoa xa hoi chu nghia viet nam: " + s1.CompareTo("cong hoa xa hoi chu nghia viet nam"));
            Console.WriteLine("compare to:  cong hoa xa hoi chu nghia viet nam: " + s1.CompareTo("cmng hoa xa hoi chu nghia viet nam"));


            Console.WriteLine("contains: xa =>" + s1.Contains("xa"));
            Console.WriteLine("contains: xo =>" + s1.Contains("xo"));

            Console.WriteLine("endswith: nam =>" + s1.EndsWith("nam"));
            Console.WriteLine("endswith:  nam =>" + s1.EndsWith("nam "));

            Console.WriteLine("indexof: hoa" + s1.IndexOf("hoa"));
            Console.WriteLine("indexof : HOA" + s1.IndexOf("HOA"));
            Console.WriteLine("indexof OrdinalIgnoreCase: HOA " + s1.IndexOf("HOA", StringComparison.OrdinalIgnoreCase));


            Console.WriteLine("insert: abc,2   " + s1.Insert(2, "abc"));


            Console.WriteLine("remove 2,3:" + s1.Remove(2, 10));

            Console.WriteLine("replace xa thanh hoa:" + s1.Replace("xa", "hoa"));

            Console.WriteLine("split dau cach:" + s1.Split(' ')[1]);

            Console.WriteLine("substring 3,5: " + s1.Substring(3, 5));
            Console.WriteLine("to upper:" + s1.ToUpper());
            Console.WriteLine("  abc   =>" + "   abc  ".Trim());

            for (int i = 0; i < s1.Length; i++)
            {
                Console.Write(s1[i] + " ");
            }
            foreach (var item in s1.Split(' '))
            {
                Console.Write(item + "    ");
            }
            Console.ReadLine();
        }
    }
}
