using System;
using Krummert.Deck.Models.Types;

namespace Krummert.Deck.models
{
    public class Card : IComparable
    {
        public CardSuite CardSuite { get; set; }
        public CardValue CardValue { get; set; }

        public int CompareTo(object obj)
        {
            Card c = (Card)obj;

            if(this.CardValue != c.CardValue)
            {
                if(this.CardValue > c.CardValue)
                    return 1;
                else 
                    return -1;
            }
            
            if(this.CardSuite == c.CardSuite)
                throw new Exception("There are two of the exact same cards in the deck");
            if(this.CardSuite > c.CardSuite)
                return 1;
            else 
                return -1;
        }
    }
}