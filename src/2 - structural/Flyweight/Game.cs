using Flyweight.Enums;
using Flyweight.Factory;
using Flyweight.Factory.Flyweights.Interfaces;

namespace Flyweight
{
    public  class Game
    {

        public void Play()
        {
            var cardFactory= new CardFactory();


            ICard[] playerOneHand = new ICard[5];
            ICard[] playerTwoHand= new ICard[5];


            playerOneHand[0] = cardFactory.GetCard(Suit.Hearts, Rank.Ace);
            playerOneHand[1] = cardFactory.GetCard(Suit.Spades, Rank.King);
            playerOneHand[2] = cardFactory.GetCard(Suit.Hearts, Rank.Ten);
            playerOneHand[3] = cardFactory.GetCard(Suit.Clubs, Rank.Three);
            playerOneHand[4] = cardFactory.GetCard(Suit.Diamonds, Rank.Seven);


            playerTwoHand[0] = cardFactory.GetCard(Suit.Hearts, Rank.Ace);
            playerTwoHand[1] = cardFactory.GetCard(Suit.Spades, Rank.King);
            playerTwoHand[2] = cardFactory.GetCard(Suit.Clubs, Rank.Three);
            playerTwoHand[3] = cardFactory.GetCard(Suit.Diamonds, Rank.Seven);
            playerTwoHand[4] = cardFactory.GetCard(Suit.Hearts, Rank.Two);

            Console.WriteLine("\nPlayer 1`s Hand:");

            for (int i = 0; i < playerOneHand.Length; i++)
                playerOneHand[i].Display(i + 1);

            Console.WriteLine("\nPlayer 2`s Hand:");

            for (int i = 0;i < playerTwoHand.Length; i++)
                playerTwoHand[i].Display(i + 1);

        }




    }
}
