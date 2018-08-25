using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSudoku
{
    class Diem
    {
        public Diem(int i,int j)
        {
            Ox = i;
            Oy = j;
               
        }

        public int Ox { get; set; }

        public int Oy { get; set; }
    }
}
