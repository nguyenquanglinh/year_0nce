using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCaro
{
    public class PlayInform
    {
        Point point;

        public Point Point
        {
            get { return point; }
            set { point = value; }
        }

        int personNew;

        public int PersonNew
        {
            get { return personNew; }
            set { personNew = value; }
        }

        public PlayInform(Point point,int personNew)
        {
            Point = point;
            PersonNew = personNew;
        }
    }
}
