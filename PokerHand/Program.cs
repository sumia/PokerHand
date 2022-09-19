using System;
using System.Dynamic;

namespace PokerHand
{
    class Program
    {
        static void Main(string[] args)
        {
            var cards = "4a 3b 15d 4c 4b";
            var hand = new Hand(cards);
            Console.WriteLine(hand.GetHandType());
            Console.ReadLine();
        }
    }
}
