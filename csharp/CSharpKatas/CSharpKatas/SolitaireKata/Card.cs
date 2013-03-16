using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKatas.SolitaireKata
{
    public class Card
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public CardType CardType { get; set; }
        public Suit Suite { get; set; }
    }

    public enum Suit
    {
        None,
        Club,
        Diamond,
        Heart,
        Spade
    }

    public enum CardType
    {
        Ace,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Joker
    }
}
