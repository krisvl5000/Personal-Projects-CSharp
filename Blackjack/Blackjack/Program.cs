using System;
using Blackjack.Core;
using Blackjack.Models.Cards;
using Blackjack.Models.Entities;

namespace _01._Hello_Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 30);
            Deck deck = new Deck();
            Dealer dealer = new Dealer(deck);
            Player player = new Player("Player");
            Engine engine = new Engine(dealer, player);
            engine.Run();
        }
    }
}