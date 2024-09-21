using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flyweight.Enums;
using Flyweight.Factory.Flyweights;
using Flyweight.Factory.Flyweights.Interfaces;

namespace Flyweight.Factory
{
    // Flyweight factory
    public class CardFactory
    {
        private Dictionary<string, ICard> _cards = new Dictionary<string, ICard>();

        public ICard GetCard(Suit suit, Rank rank)
        {
            string key = $"{suit}_{rank}";

            if (!_cards.ContainsKey(key))
            {
                _cards[key] = new Card(suit, rank);
                Console.WriteLine($"Creating {rank} of {suit}");
            }


            return _cards[key];


        }


    }
}
