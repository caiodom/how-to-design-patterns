using Flyweight.Enums;
using Flyweight.Factory.Flyweights.Interfaces;

namespace Flyweight.Factory.Flyweights
{
    // The concrete Flyweight class
    public class Card : ICard
    {

        private readonly Suit _suit;
        private readonly Rank _rank;


        public Card(Suit suit, Rank rank)
        {
            _suit = suit; // Intrinsic state (shared)
            _rank = rank; // Intrinsic state (shared)
        }

        public void Display(int position)
        {
            //position -> extrinsic state
            Console.WriteLine($"{_rank} of {_suit}, Position: {position} ");
        }
    }
}
