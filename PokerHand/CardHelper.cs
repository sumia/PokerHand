using System.Collections.Generic;

namespace PokerHand
{
    public static class CardHelper
    {
        public static Dictionary<int, int> ParseCards(IEnumerable<Card> cards)
        {
            var d = new Dictionary<int, int>();

            foreach (var card in cards)
                if (d.ContainsKey(card.GetNumber()))
                {
                    ++d[card.GetNumber()];
                }
                else
                {
                    d[card.GetNumber()] = 1;
                }

            return d;

        }
    }
}
