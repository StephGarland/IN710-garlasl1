using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Deck
    {
        List<Card> deck;
        private static Random randomN = new Random();

        public Deck()
        {
            deck = new List<Card>();
            Populate();
        }

        public virtual void Populate()
        {
            //populate deck with the traditional 52 cards
            string[] suits = new string[] { "C", "D", "H", "S" };
            string[] ranks = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "T",
                                            "J", "Q", "K", "1" };

            //for each suit,
            for (int i = 0; i < suits.Length; i++)
            {
                // make 13 cards
                for (int j = 0; j < ranks.Length; j++)
                {
                    int HCP_Value = 0;
                    //last 5 ranks have increasing points value
                    if (j >= 11)
                    {
                        HCP_Value += 1;
                    }
                    Card card = new Card(suits[i], ranks[j], HCP_Value);
                    deck.Add(card);
                }
            }
        }
        

        public void Shuffle()
        {
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = randomN.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        public Card Deal()
        {
            //deal one card, until deck has been exhausted.
            //get last card in deck
            Card card = deck[deck.Count - 1];
            //remove from deck
            deck.Remove(card);
            return card;
        }

        public int GetSize()
        {
            return deck.Count();
        }


    }
}
