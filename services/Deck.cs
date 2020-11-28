using System;
using System.Collections.Generic;
using Krummert.Deck.models;
using Krummert.Deck.Models.Types;

namespace Krummert.Deck.Services
{
    public class Deck : Hand
    {
        public void CreateDeck()
        {
            foreach(byte cardValue in Enum.GetValues(typeof(CardValue)))
            {
                foreach(byte cardSuite in Enum.GetValues(typeof(CardSuite)))
                {
                    _Cards.Add(new Card()
                    {
                        CardValue = (CardValue)cardValue,
                        CardSuite = (CardSuite)cardSuite
                    });
                }
            }
        }

        public void ShuffleDeck() 
        {
            if(_Cards.Count == 0) 
            {
                CreateDeck();
            }

            var ran = new Random((int)DateTime.Now.Ticks);
            var numberOfShuffles = ran.Next(1, 100) * 2;

            for(var i = 0; i < numberOfShuffles; i++) 
            {
                var card1 = ran.Next(0, _Cards.Count);
                var card2 = ran.Next(0, _Cards.Count);

                var temp = _Cards[card1];
                
                _Cards[card1] = _Cards[card2];
                _Cards[card2] = temp;
            }
        }

        public Card DealOneCard() 
        {
            if(_Cards.Count == 0) {
                throw new Exception("No Cards Left");
            }

            var temp = _Cards[0];
            _Cards.RemoveAt(0);
            return temp;
        }
        public List<Card> DealCards(int count) 
        {
            if(count > _Cards.Count) 
                throw new Exception("Not Enough Cards In Deck");

            var returnList = new List<Card>();
            while(--count > 0)
            {
                returnList.Add(_Cards[0]);
                _Cards.RemoveAt(0);
            }

            return returnList;
        }
    }
}