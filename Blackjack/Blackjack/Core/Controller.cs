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
        private bool playerBlackjack;

        public Controller(Dealer dealer, IEntity player)
        {
            this.dealer = dealer;
            this.player = player;
        }

        public void InitialDealing()
        {
            Random random = new Random();
            int randomNum = random.Next(0, dealer.Deck.Cards.Count);
            playerBlackjack = false;
            bool dealerBlackjack = false;

            // Dealing player the first card
            Card dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard);
            player.Score += dealtCard.Value;
            player.Hand.Add(dealtCard);

            // Dealing the dealer first card
            randomNum = random.Next(0, dealer.Deck.Cards.Count);
            dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard);
            dealer.Hand.Add(dealtCard);

            //Dealing the player the second card (face down)
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

            Card dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard);
            player.Score += dealtCard.Value;
            player.Hand.Add(dealtCard);

            PrintCards();

            if (HasPlayerBusted())
            {
                DealerWins();
            }
            else if (HasDealerBusted())
            {
                PlayerWins(false);
            }
        }

        public void Stand()
        {
            Console.WriteLine($"Dealer cards: {String.Join(" ", dealer.Hand)}   Total value: {GetHandValue(dealer.Hand)}");

            if (GetHandValue(dealer.Hand) < 17)
            {
                Console.WriteLine("Press any key when you are ready for the dealer to draw a new card.");
                Console.ReadKey();
            }

            while (GetHandValue(dealer.Hand) < 17) // draws even if he has an ace and the total is above 16
            {

                if (dealer.Hand.Any(x => x.Face == "A") && dealer.Hand[1].Value + 11 > 16)
                {
                    break;
                }

                Random random = new Random();
                int randomNum = random.Next(0, dealer.Deck.Cards.Count);
                var dealtCard = dealer.Deck.Cards[randomNum];
                dealer.Deck.Cards.Remove(dealtCard);
                dealer.Hand.Add(dealtCard);

                Console.WriteLine();

                Console.WriteLine($"Dealer cards: {String.Join(" ", dealer.Hand)}   Total value: {GetHandValue(dealer.Hand)}");
                Console.WriteLine($"Your cards: {String.Join(" ", player.Hand)}   Total value: {GetHandValue(player.Hand)}");

                Console.WriteLine();

                if (GetHandValue(dealer.Hand) > 16)
                {
                    break;
                }

                Console.WriteLine("Press any key when you are ready for the dealer to draw a new card.");
                Console.ReadKey();
            }

            // When he has to stand because the value is at least 17

            if (HasDealerBusted())
            {
                PlayerWins(playerBlackjack);
                return;
            }

            if (GetHandValue(player.Hand) > GetHandValue(dealer.Hand))
            {
                PlayerWins(playerBlackjack);
            }
            else if (GetHandValue(dealer.Hand) > GetHandValue(player.Hand))
            {
                DealerWins();
            }
            else
            {
                if (dealer.TotalBetPool > 0)
                {
                    Push();
                }
                else
                {
                    RestartGame();
                }
            }
        }

        public void Split()
        {

        }

        public void DoubleDown()
        {
            Random random = new Random();
            int randomNum = random.Next(0, dealer.Deck.Cards.Count);
            Card dealtCard = dealer.Deck.Cards[randomNum];
            dealer.Deck.Cards.Remove(dealtCard);
            player.Score += dealtCard.Value;
            player.Hand.Add(dealtCard);

            Console.WriteLine();
            Console.WriteLine("You doubled down!");

            Console.WriteLine($"Your cards: {String.Join(" ", player.Hand)}   Total value: {GetHandValue(player.Hand)}");

            if (GetHandValue(player.Hand) > 21)
            {
                DealerWins();
            }
            else
            {
                Console.WriteLine();
                Stand();
            }
        }

        public void Push()
        {
            player.Balance += dealer.TotalBetPool;
            Console.WriteLine($"You pushed! You got your ${dealer.TotalBetPool} back!");
            //RestartGame();
            dealer.TotalBetPool = 0;
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

            Console.WriteLine();

            Console.WriteLine($"Congratulations, you won the hand! You won ${dealer.TotalBetPool:F2}!");

            Console.WriteLine();

            //RestartGame();
            dealer.TotalBetPool = 0;
        }

        public void DealerWins()
        {
            Console.WriteLine();

            Console.WriteLine($"Sorry, you lost! Remaining balance: ${player.Balance:F2}");

            Console.WriteLine();

            //RestartGame();
            dealer.TotalBetPool = 0;
        }

        public void Bet(int bet)
        {
            dealer.TotalBetPool += bet;
            player.Balance -= bet;
        }

        public void RestartGame()
        {
            Console.WriteLine("Press any key to start a new game");
            Console.ReadKey();
            Console.Clear();
            Deck deck = new Deck();
            dealer.TotalBetPool = 0;
            dealer.Deck = deck;

            dealer.Hand.Clear();
            dealer.Score = 0;

            player.Hand.Clear();
            player.Score = 0;
        }

        public void PrintCards()
        {
            Console.WriteLine($"Dealer cards: {dealer.Hand[1]}   Total value: {dealer.Hand[1].Value}");
            Console.WriteLine($"Your cards: {String.Join(" ", player.Hand)}   Total value: {GetHandValue(player.Hand)}");
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
