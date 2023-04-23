using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Models.Entities;

namespace Blackjack.Core
{
    public class Engine
    {
        private IEntity dealer;
        private IEntity player;

        public Engine(IEntity dealer, IEntity player)
        {
            this.dealer = dealer;
            this.player = player;
        }

        public void Run()
        {

        }
    }
}
