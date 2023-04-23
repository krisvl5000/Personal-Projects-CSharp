using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Blackjack.Models.Cards;

namespace Blackjack.Models.Entities
{
    public class Dealer : IEntity
    {
        public Dealer(Deck deck)
        {
            Name = "Dealer";
            Balance = 9999999;
            Deck = deck;
        }

        public string Name { get; set; }

        public int Balance { get; set; }

        public Deck Deck { get; set; }

        public void Deal()
        {

        }
    }
}
