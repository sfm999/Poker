using Poker.Models;

class Startup
{
  static void Main(string[] args)
  {
        // Welcome message
        Console.WriteLine("Welcome to 5-hand Poker!");

        Deck deck = new Deck();

        deck.Shuffle();
        deck.DisplayAllCards();
  }
}
