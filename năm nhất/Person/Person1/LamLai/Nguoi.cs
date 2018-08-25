using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamLai
{
    public class Nguoi
    {
        string name, age, gender, adress;

        public Nguoi()
        {
            Name = name;
            Age = age;
            Adress = adress;
            Gender = gender;
        }

        public Nguoi(string name,string age,string adress,string gender)
        {
            Name = name;
            Age = age;
            Adress = adress;
            Gender = gender;
        }
        public string Name
        {
           get
            {
                return name;
            }
            set
            {
                name = value;
                if (value == "")
                {
                    name = "chưa nhập tên";
                }
            }
        }

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                if (value == "")
                    age = "0";
            }
        }

        public int Stt
        {
            get; set;
        }

        public string Gender
        {
         get
            {
                return gender;
            }
            set
            {
                gender = value;
                if (value == "")
                    gender = "chưa nhập giới tính";
            }
        }

        public string Adress
        {
          get
            {
                return adress;
            }
            set
            {
                adress = value;
                if (value == "")
                {
                    adress = "chưa nhâp địa chỉ";
                }
            }
        }

        public override string ToString()
        {
            return "tên : " + Name + "\ttuổi : " + Age + "\t giới tính : " + Gender + "\t Địa chỉ : " + Adress;
        }
    }
}
