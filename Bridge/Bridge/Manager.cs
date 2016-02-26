using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Manager
    {
        Deck deck;
        List<Hand> playerHands;

        public Manager()
        {
            deck = new Deck();
            playerHands = new List<Hand>();
            AddHands();

            deck.Shuffle();
            Deal();

            //prompt players to each in turn 
            // - Display hand
            // - Display HCP score
        }

        public void AddHands()
        {
            playerHands.Add(new Hand("North", 13));
            playerHands.Add(new Hand("East", 13));
            playerHands.Add(new Hand("South", 13));
            playerHands.Add(new Hand("West", 13));
        }

        public void Deal()
        {
            //until the deck is dead, 
            while(deck.GetSize() > 0)
            {
                //cycle through each player
                for (int i = 0; i < playerHands.Count; i++)
                {
                    //and so long has the deck hasn't just been exhausted
                    if(deck.GetSize() > 0)
                    {
                        //deal a card
                        playerHands[i].AddCard(deck.Deal());
                    }   
                }
            }
        }

        public List<string> RevealHands()
        {
            List<string> hand = new List<string>();
            //add player Name
            //add 4 lines of score, one for each suit
            //add HCP
            for (int i = 0; i < playerHands.Count; i++)
            {
                //add player Name
                hand.Add(playerHands[i].GetName());
                hand.Add(" ");
                //add 4 lines of score, one for each suit
                hand.Add("score score score");
                //add HCP
                hand.Add(playerHands[i].CalculatePoints().ToString());
            }         
            
            return hand;
        }
    }
}
