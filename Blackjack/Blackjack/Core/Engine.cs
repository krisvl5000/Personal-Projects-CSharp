using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Blackjack.Models.Entities;

namespace Blackjack.Core
{
    public class Engine
    {
        private Dealer dealer;
        private IEntity player;
        private Controller controller;

        public Engine(Dealer dealer, Player player)
        {
            this.dealer = dealer;
            this.player = player;
            controller = new Controller(this.dealer, this.player);
        }

        public void Run()
        {
            controller.InitialDealing();

            while (true)
            {
                
            }
        }
    }
}
