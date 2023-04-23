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
            Console.WriteLine($"OK, let's play some blackjack! How much do you want to bet? Your balance is {player.Balance}.");

            int bet = 0;

            while (true)
            {
                bool exceptionCaught = false;

                try
                {
                    bet = int.Parse(Console.ReadLine());

                    if (bet > player.Balance)
                    {
                        throw new InvalidOperationException();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    exceptionCaught = true;
                    Console.WriteLine($"Bet value cannot be greater than your balance ({player.Balance}).");
                }
                catch (Exception ex)
                {
                    exceptionCaught = true;
                    Console.WriteLine("Please only write whole numbers as bets.");
                }

                if (!exceptionCaught)
                {
                    break;
                }
            }

            controller.Bet(bet);

            controller.InitialDealing();

            while (true)
            {
                
            }
        }
    }
}
