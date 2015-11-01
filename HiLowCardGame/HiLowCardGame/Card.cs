using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLowCardGame
{
    class Card
    {
        public static int DIAMOND = 1;
        public static int CLUB = 2;
        public static int HEART = 3;
        public static int SPADE = 4;

        public int Suit { get; set; }
        public int Rank { get; set; }
  

        public Card(int Suit,int Rank)
        {
            this.Suit = Suit;
            this.Rank = Rank;
        }

        public override string ToString()
        {
            if(Suit == DIAMOND)
                return $"Diamond of {Rank}";
            else if(Suit == CLUB)
                return $"Club of {Rank}";
            else if(Suit == HEART)
                return $"Heart of {Rank}";
            else
                return $"Spade of {Rank}";

        }
        
    }
}
