using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Models.Cards;

namespace Blackjack.Models.Entities
{
    public interface IEntity
    {
        public string Name { get; set; }

        public int Balance { get; set; }

        public int Score { get; set; }

        public List<Card> Hand { get; set; }
    }
}
