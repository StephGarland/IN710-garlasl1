using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Card : IComparable<Card>
    {
        static string[] suits = new string[] { "C", "D", "H", "S" };
        static string[] ranks = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "T",
                                            "J", "Q", "K", "1" };
        string suit;
        string rank;
        int HCP_Value;

        public int HCP_Value1
        {
            get
            {
                return HCP_Value;
            }
        }

        public string Rank
        {
            get
            {
                return rank;
            }
        }

        public string Suit
        {
            get
            {
                return suit;
            }
        }

        public Card(string suit, string rank, int HCP_Value)
        {
            this.suit = suit;
            this.rank = rank;
            this.HCP_Value = HCP_Value;
        }

        public int CompareTo(Card other)
        {
            //if it's the same suit
            if(suit == other.suit)
            {
                int thisOne = Array.IndexOf(ranks, rank);
                int thatOne = Array.IndexOf(ranks, other.Rank);
                if (thisOne > thatOne)
                {
                    return 1;
                }
                else if(thisOne == thatOne)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
                //check the rank
                //if(rank )
            }
            //if the suit is different
            else
            {
                //compare suits
                int thisOne = Array.IndexOf(suits, suit);
                int thatOne = Array.IndexOf(suits, other.Suit);
                //if this one's greater
                if (thisOne > thatOne)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }          
        }
    }
}
