using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Models.Cards;
using Blackjack.Models.Entities;

namespace Blackjack.Core
{
    public class Controller
    {
        private Dealer dealer;
        private IEntity player;

        public Controller(Dealer dealer, IEntity player)
        {
            this.dealer = dealer;
            this.player = player;
        }

        public void InitialDealing()
        {
            Random random = new Random();
            int randomNum = random.Next(0, dealer.Deck.Cards.Count);

            // Dealing player the first card
            Card dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard); // there is a chance it won't be removed
            player.Score += dealtCard.Value;

            // Dealing the dealer first card
            randomNum = random.Next(0, dealer.Deck.Cards.Count);
            dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Score += dealtCard.Value;

            //Dealing the player the second card
            dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard);
            player.Score += dealtCard.Value;

            // Dealing the dealer the second card
            randomNum = random.Next(0, dealer.Deck.Cards.Count);
            dealtCard = dealer.Deck.Cards[randomNum];
            
            // Checking if the dealer has blackjack
            if (dealer.Score + dealtCard.Value == 21)
            {
                if (player.Score == 21)
                {

                }
            }
        }

        public void Hit()
        {

        }

        public void Stand()
        {

        }

        public void Split()
        {

        }

        public void DoubleDown()
        {

        }

        public void Push()
        {

        }
    }
}
