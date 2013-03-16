using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpKatas.SolitaireKata;
using Xunit;

namespace CSharpKatas.Tests.SolitaireKata
{
    public class DeckFacts
    {
        public class TheDeck
        {
            [Fact]
            public void ShouldHave54Cards()
            {
                var deck = new Deck();

                var actualNumberOfCards = deck.CardDeck.Count;

                Assert.Equal(54, actualNumberOfCards);
            }

            [Fact]
            public void ShouldHaveTwoJokers()
            {
                var deck = new Deck();

                var actualNumberOfJokers = deck.CardDeck.Count(x => x.CardType == CardType.Joker);

                Assert.Equal(2, actualNumberOfJokers);
            }

            [Fact]
            public void ShouldHaveUniqueNamesForAllCards()
            {
                var deck = new Deck();

                var actualDuplicateNamedCardsCound = deck.CardDeck.GroupBy(card => card.Name).Count(group => group.Count() > 1);

                Assert.Equal(0, actualDuplicateNamedCardsCound);
            }
        }
    }
}
