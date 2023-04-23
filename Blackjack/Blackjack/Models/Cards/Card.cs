using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Models.Cards
{
    public class Card : ICard
    {
        public Card()
        {
            
        }

        public int Value { get; set; }
        public string Suit { get; set; }
    }
}
