using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChatForm
{
    public class Player
    {
        public Player(string namePlayer, Image playerPhoto, int indexPlayer)
        {
            this.NamePlayer = namePlayer;
            this.PlayerPhoto = playerPhoto;
            this.Index = indexPlayer;
        }

        public string NamePlayer { get; set; }

        public Image PlayerPhoto { get; set; }

        public int Index { get; set; }
    }
}
