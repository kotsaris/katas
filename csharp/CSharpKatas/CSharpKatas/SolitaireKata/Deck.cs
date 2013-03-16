using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKatas.SolitaireKata
{
    public class Deck
    {
        public List<Card> CardDeck { get; set; }

        public Deck()
        {
            CardDeck = new List<Card>();
            CardDeck.AddRange(GetCardsForSuit(Suit.Club));
            CardDeck.AddRange(GetCardsForSuit(Suit.Diamond));
            CardDeck.AddRange(GetCardsForSuit(Suit.Heart));
            CardDeck.AddRange(GetCardsForSuit(Suit.Spade));
            CardDeck.Add(GetJockerCard("Mitsos"));
            CardDeck.Add(GetJockerCard("Kitsos"));
        }

        private Card GetJockerCard(string jokerName)
        {
            return new Card
                       {
                           Name = string.Format("{0} the Joker", jokerName),
                           Value = GetPointsForCardType(CardType.Joker),
                           CardType = CardType.Joker
                       };
        }

        private IEnumerable<Card> GetCardsForSuit(Suit suit)
        {
            var listOfCardTypes = new List<CardType>();
            listOfCardTypes.AddRange(new CardType[]
                                     {
                                         CardType.Ace,
                                         CardType.Two,
                                         CardType.Three,
                                         CardType.Four,
                                         CardType.Five,
                                         CardType.Six,
                                         CardType.Seven,
                                         CardType.Eight,
                                         CardType.Nine,
                                         CardType.Ten,
                                         CardType.Jack,
                                         CardType.Queen,
                                         CardType.King,
                                     });
            return listOfCardTypes.Select(cardType => new Card()
                                                                     {
                                                                         Name = string.Format("{0} of {1}s", cardType, suit.ToString()),
                                                                         Value = GetPointsForCardType(cardType) + GetExtraPointsForSuit(suit),
                                                                         CardType = cardType
                                                                     });
        }

        private int GetExtraPointsForSuit(Suit suit)
        {
            switch (suit)
            {
                case(Suit.None):
                    return 0;
                case (Suit.Club):
                    return 0;
                case (Suit.Diamond):
                    return 13;
                case (Suit.Heart):
                    return 26;
                case (Suit.Spade):
                    return 39;
                default:
                    throw new Exception("Suit was not found");
            }
        }

        private int GetPointsForCardType(CardType cardType)
        {
            switch (cardType)
            {
                case (CardType.Ace):
                    return 1;
                case (CardType.Two):
                    return 2;
                case (CardType.Three):
                    return 3;
                case (CardType.Four):
                    return 4;
                case (CardType.Five):
                    return 5;
                case (CardType.Six):
                    return 6;
                case (CardType.Seven):
                    return 7;
                case (CardType.Eight):
                    return 8;
                case (CardType.Nine):
                    return 9;
                case (CardType.Ten):
                    return 10;
                case (CardType.Jack):
                    return 11;
                case (CardType.Queen):
                    return 12;
                case (CardType.King):
                    return 13;
                case (CardType.Joker):
                    return 53;
                default:
                    throw new Exception("Card points were not found for card :" + cardType);
            }
        }
    }
}
