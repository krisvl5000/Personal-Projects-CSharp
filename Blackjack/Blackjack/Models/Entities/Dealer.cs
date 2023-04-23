using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Models.Entities
{
    public class Dealer : IEntity
    {
        public Dealer()
        {
            Name = "Dealer";
            Balance = 9999999;
        }

        public string Name { get; set; }

        public int Balance { get; set; }
    }
}
