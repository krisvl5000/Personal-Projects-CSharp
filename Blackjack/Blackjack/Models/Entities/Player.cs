using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Models.Cards;

namespace Blackjack.Models.Entities
{
    public class Player : IEntity
    {
        public Player(string name)
        {
            Name = name;
            Balance = 1000;

            Hand = new List<Card>();
            SecondHand = new List<Card>();
        }

        public string Name { get; set; }

        public int Balance { get; set; }

        public int Score { get; set; }

        public List<Card> Hand { get; set; }

        public List<Card> SecondHand { get; set; }
    }
}
