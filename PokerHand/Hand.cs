using System.Collections.Generic;
using System.Linq;

namespace PokerHand
{
    public  class Hand
    {
        private string cards;
        public Hand(string cards)
        {
            this.cards = cards;
        }

        public IEnumerable<Card> GetCards()
        {
            return cards.Split(" ").Select(x => new Card(x.Trim()));
        }

    }
}