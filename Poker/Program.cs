using Poker.Models;

class Startup
{
  static void Main(string[] args)
  {
        // Welcome message
        Console.WriteLine("Welcome to 5-hand Poker!");

        Deck deck = new Deck();

        deck.Shuffle();


        int playerCount = 5;
        int handSize = 5;

        List<Hand> hands = new List<Hand>();

        for(int i = 0; i < playerCount; i++)
        {
            List<Card> cards = deck.DealHand(handSize: handSize, playerCount: playerCount, playerNumber: i);
            Hand hand = new Hand();
            foreach (Card card in cards)
                hand.AddCard(card);
            hands.Add(hand);
        }

        foreach (Hand hand in hands)
            hand.DisplayCards();

  }
}
