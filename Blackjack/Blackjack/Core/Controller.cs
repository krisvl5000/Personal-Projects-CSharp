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
            bool playerBlackjack = false;
            bool dealerBlackjack = false;

            // Dealing player the first card
            Card dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard); // there is a chance it won't be removed
            player.Score += dealtCard.Value;
            player.Hand.Add(dealtCard);

            // Dealing the dealer first card
            randomNum = random.Next(0, dealer.Deck.Cards.Count);
            dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard);
            dealer.Score += dealtCard.Value;
            dealer.Hand.Add(dealtCard);

            //Dealing the player the second card
            randomNum = random.Next(0, dealer.Deck.Cards.Count);
            dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard);
            player.Score += dealtCard.Value;
            player.Hand.Add(dealtCard);

            // Checking if the player has blackjack
            if (player.Score == 21)
            {
                playerBlackjack = true;
            }

            // Dealing the dealer the second card
            randomNum = random.Next(0, dealer.Deck.Cards.Count);
            dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard);
            dealer.Hand.Add(dealtCard);

            // Checking if the dealer has blackjack
            if (dealer.Score + dealtCard.Value == 21)
            {
                dealerBlackjack = true;
            }

            // Checking outcome
            if (playerBlackjack && dealerBlackjack)
            {
                Push();
            }
            else if (playerBlackjack && !dealerBlackjack)
            {
                PlayerWins();
            }
            else if (dealerBlackjack && !playerBlackjack)
            {
                DealerWins();
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

        public void PlayerWins()
        {

        }

        public void DealerWins()
        {

        }
    }
}
