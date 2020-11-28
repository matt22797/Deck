using System;

namespace Krummert.Deck
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Krummert.Deck.Services.Deck();
            var hand = new Krummert.Deck.Services.Hand();

            deck.CreateDeck();
            deck.ShuffleDeck();
            
            hand.AddRange(deck.DealCards(52));
            hand.Sort();
            hand.Print();
        }
    }
}
