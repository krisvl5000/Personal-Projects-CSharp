﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Models.Cards
{
    public class Card : ICard
    {
        public Card(int value, string suit, string face)
        {
            Value = value;
            Suit = suit;
            Face = face;
        }

        public int Value { get; set; }
        public string Suit { get; set; }
        public string Face { get; set; }

        public override string ToString()
        {
            return $"{Face}({Suit})";
        }
    }
}
