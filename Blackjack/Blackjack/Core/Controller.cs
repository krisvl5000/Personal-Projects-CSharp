using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
            dealer.Score += dealtCard.Value;
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
                PlayerWins(playerBlackjack);
            }
            else if (dealerBlackjack && !playerBlackjack)
            {
                DealerWins();
            }

            PrintCards();
        }

        public void Hit()
        {
            Random random = new Random();
            int randomNum = random.Next(0, dealer.Deck.Cards.Count);
            bool playerBlackjack = false;

            Card dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard);
            player.Score += dealtCard.Value;
            player.Hand.Add(dealtCard);
            PrintCards();
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
            player.Balance += dealer.TotalBetPool;
            RestartGame();
        }

        public void PlayerWins(bool blackJack)
        {
            if (blackJack)
            {
                player.Balance += dealer.TotalBetPool + 
                                  dealer.TotalBetPool * 3 / 2;
            }
            else
            {
                player.Balance += dealer.TotalBetPool * 2;
            }

            Console.WriteLine($"Congratulations, you won the hand! You won ${dealer.TotalBetPool:F2}!");

            RestartGame();
        }

        public void DealerWins()
        {
            Console.WriteLine($"Sorry, you lost! Remaining balance: ${player.Balance:F2}");
            RestartGame();
        }

        public void Bet(int bet)
        {
            dealer.TotalBetPool += bet;
            player.Balance -= bet;
        }

        public void RestartGame()
        {
            Deck deck = new Deck();
            dealer.TotalBetPool = 0;
            dealer.Deck = deck;

            dealer.Hand.Clear();
            player.Hand.Clear();
        }

        public void PrintCards()
        {
            Console.WriteLine($"Dealer cards: {dealer.Hand[1]}");
            Console.WriteLine($"Your cards: {String.Join(" ", player.Hand)}");
            Console.WriteLine($"How do you want to proceed?");
        }

        private bool HasPlayerBusted()
        {
            bool playerHasBusted = GetHandValue(player.Hand) > 21;

            return playerHasBusted;
        }

        private bool HasDealerBusted()
        {
            bool dealerHasBusted = GetHandValue(dealer.Hand) > 21;

            return dealerHasBusted;
        }

        private int GetHandValue(List<Card> list)
        {
            int value = 0;
            int numAces = 0;

            foreach (var card in list)
            {
                if (card.Face == "A")
                {
                    numAces++;
                    value++;
                }
                else
                {
                    value += card.Value;
                }
            }

            while (numAces > 0 && value + 10 <= 21)
            {
                value += 10;
                numAces--;
            }

            return value;
        }
    }
}
