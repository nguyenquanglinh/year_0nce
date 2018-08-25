using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCaro
{
    public class Player
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        Image player;

        public Image PlayerMark
        {
            get { return player; }
            set { player = value; }
        }

        public Player(string name, Image player)
        {
            Name = name;
            PlayerMark = player;
        }
    }
}
