using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuocTinhAccessor
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s = new HocSinh();
            //s.ten1 = "a";
            //s.tuoi1 = "3";
            //s.maSv1 = "99";
            //Console.WriteLine(s);
            //Console.ReadKey();
        }
    }

    public abstract class HocSinh
    {

        public string Ten { get; set; }
        public string tuoi1
        {
            get;
            set;
        }
        public string maSv1
        {
            get;
            set;
        }
        public override string ToString()
        {
            return "sv" + maSv1 + " " + Ten + " " + tuoi1;
        }
    }

    class Nguoi : HocSinh
    {
    }

}