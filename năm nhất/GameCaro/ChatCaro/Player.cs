using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChatCaro
{
    public class Player
    {
        public Player(string namePlayer,Image playerPhoto)
        {
            this.NamePlayer = namePlayer;
            this.PlayerPhoto = playerPhoto;
        }

        public string NamePlayer { get; set; }

        public Image PlayerPhoto { get; set; }
    }
}
