using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Blackjack.Models.Cards
{
    public class Deck
    {
        public Deck()
        {

        }

        public List<Card> Cards => InitializeDeck();

        private List<Card> InitializeDeck()
        {
            var cards = new List<Card>();
            var suit = "";

            for (int j = 0; j < 4; j++)
            {
                for (int i = 2; i < 14; i++)
                {
                    if (i <= 10)
                    {
                        var newCard = new Card(i, CheckSuit(j), i.ToString());
                    }
                    else if (i == 11)
                    {

                    }
                }
            }

            return cards;
        }

        private string CheckSuit(int j)
        {
            var suit = "";

            if (j == 0)
            {
                suit = "♠";
            }
            else if (j == 1)
            {
                suit = "♥";
            }
            else if (j == 2)
            {
                suit = "♦";
            }
            else
            {
                suit = "♣";
            }

            return suit;
        }
    }
}
