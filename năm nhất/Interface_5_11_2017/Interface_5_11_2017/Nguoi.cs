using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_5_11_2017
{
    class Nguoi
    {
        public Nguoi()
        {
            Name = "chưa nhập tên";
            Age = "chưa nhập tuổi";
            Address = "chưa nhập địa chỉ";
            Gender = "chưa nhập giới tính";
        }
        public String Name
        {
            get;set;
        }
        public string Age
        {
            get;set;
        }
        public String Address
        {
            get;set;
        }
        public string Gender
        {
            get;set;
        }
        public override string ToString()
        {
            return Name + "," + Age + "," + Address + "," + Gender + ",";
        }
    }
}
