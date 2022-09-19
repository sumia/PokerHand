using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
    public class ThreeOfAKindCard : IHandType
    {
        private const string CardType = "Three of a Kind";
        public static bool IsThreeOfaKind(IEnumerable<Card> cards)
        {
            var d = CardHelper.ParseCards(cards);
            return d.Values.Any(x => x >= 3);
        }

        public string GetHandType() { return CardType; }
    }
}
