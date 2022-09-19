using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
    public class FlushCard : IHandType
    {
        private const string CardType = "Flush";
        public static bool IsFlush(IEnumerable<Card> cards)
        {
            var lastChar = cards.ElementAt(0).GetCharacter();

            var isFlush = cards.All(x => x.GetCharacter() == lastChar);
            return isFlush;
        }

        public string GetHandType() => CardType;
    }
}
