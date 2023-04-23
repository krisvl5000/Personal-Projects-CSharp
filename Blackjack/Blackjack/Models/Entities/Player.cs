using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Models.Entities
{
    public class Player : IEntity
    {
        public Player(string name)
        {
            Name = name;
            Balance = 1000;
        }

        public string Name { get; set; }

        public int Balance { get; set; }

        public int Score { get; set; }
    }
}
