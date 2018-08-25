using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form2
{
    class Nguoi  
    {
        public Nguoi()
        {
            Name = "New People";
            Age = "0";
        }

        public string Name
        {
            get; set;
        }
        public string Age
        {
            get; set;
        }

        public Nguoi(string ten, string tuoi)
        {
            Name = ten;
            Age = tuoi;
        }
          

    }
}
