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
            Cards = InitializeDeck();
        }

        public List<ICard> Cards;

        private List<ICard> InitializeDeck()
        {
            var cards = new List<ICard>();
            var suit = "";

            ICard newCard = null;

            for (int j = 0; j < 4; j++)
            {
                for (int i = 2; i < 15; i++)
                {
                    if (i <= 10)
                    {
                        newCard = new Card(i, CheckSuit(j), i.ToString());
                    }
                    else if (i == 11)
                    {
                        newCard = new Card(10, CheckSuit(j), "J");
                    }
                    else if (i == 12)
                    {
                        newCard = new Card(10, CheckSuit(j), "Q");
                    }
                    else if (i == 13)
                    {
                        newCard = new Card(10, CheckSuit(j), "K");
                    }
                    else
                    {
                        newCard = new Card(11, CheckSuit(j), "A");
                    }

                    cards.Add(newCard);
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
