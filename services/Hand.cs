using System;
using System.Collections.Generic;
using Krummert.Deck.models;
using Krummert.Deck.Models.Types;

namespace Krummert.Deck.Services
{
    public class Hand 
    {
        protected List<Card> _Cards;
        public Hand() 
        {
            _Cards = new List<Card>();
        }

        public void Add(Card card)
        {
            _Cards.Add(card);
        }
        public void AddRange(List<Card> cards)
        {
            foreach(var card in cards)
            {
                _Cards.Add(card);
            }
        }
        public void Print()
        {
            foreach(var card in _Cards)
            {
                Console.WriteLine(card.CardValue + " of " + card.CardSuite);
            }
        }
        public void Sort() 
        {
            _Cards.Sort();
        }
    }
}