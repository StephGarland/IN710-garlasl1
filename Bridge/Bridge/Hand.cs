using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Hand
    {
        List<Card> hand;
        string name;
        int MaxSize;

        public Hand(string name, int maxSize)
        {
            this.name = name;
            hand = new List<Card>();
            this.MaxSize = maxSize;
        }

        public void Sort()
        {
            //sort hand into high to low value
            hand.Sort();
        }

        public virtual int CalculatePoints()
        {
            //calculate the HCP of the hand
            int HCP = 0;
            for (int i = 0; i < hand.Count; i++)
            {
                HCP += hand[i].HCP_Value1;
            }
            return HCP;
        }

        public bool AddCard(Card card)
        {
            bool success = false;
            if(hand.Count <= MaxSize)
            {
                hand.Add(card);
                success = true;
            }
            return success;
        }

        public List<Card> GetHand()
        {
            Sort();
            return hand;
        }

        public string GetName()
        {
            return name;
        }
    }
}
