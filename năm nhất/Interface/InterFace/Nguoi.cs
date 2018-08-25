using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    class Nguoi
    {
        public Nguoi()
        {
            Name = "chưa nhập tên";
            Age = "0";
            Adress = "chưa nhập địa chỉ";
        }
        string Name
        {
            get; set;
        }
        string Age
        {
            get; set;
        }

        string Adress
        {
            get; set;
        }

        public override string ToString()
        {
            return Name + "," + Age + "," + Adress + ",";
        }

    }
}
