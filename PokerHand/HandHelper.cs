using System;
using System.Linq;

namespace PokerHand
{
    public static class HandHelper
    {
        private static bool ContainsValidNumber(int x) => x >= 1 && x <= 13;
        private static bool ContainsValidCharacter(char x) => x >= 'a' && x <= 'd';

        public static string GetHandType(this Hand hand)
        {
            var validHand = Validate(hand);
            if (!validHand.Valid) return validHand.Msg;

            if (FlushCard.IsFlush(hand.GetCards())) { return FlushCard. }
            else if (ThreeOfAKindCard.IsThreeOfaKind(hand.GetCards())) { return "ThreeOfAKindCard"; }
            //else if (PairCard.IsPair(hand.GetCards())) { return PairCard.GetType(); }
            else return "Undefined Hand";
        }

        private static (bool Valid, string Msg) Validate(Hand hand)
        {
            if (hand.GetCards().Any(card => !ContainsValidNumber(card.GetNumber())))
                return (false, "Invalid numbers in cards");
            if (hand.GetCards().Any(card => !ContainsValidCharacter(card.GetCharacter())))
                return (false, "Invalid character in cards");

            return (true, "");
        }
    }
}
