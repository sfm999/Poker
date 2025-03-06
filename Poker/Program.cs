using poker.Models;

class Startup
{
  static void Main(string[] args)
  {
    // Welcome message
    Console.WriteLine("Welcome to 5-hand Poker!");

    char club = '\u2660';
    // Suits
    //                spade     club      heart     diamond
    char[] suits = { '\u2660', '\u2663', '\u2665', '\u2666' };

    // Ranks
    char[] ranks = { 'A', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'J', 'Q', 'K' };

    Card[] deck = new Card[52];
    int index = 0;

    for (int i = 0; i < 4; i++)
    {
      for (int j = 0; j < 13; j++)
      {
        deck[index] = new Card(suits[i], ranks[j]);
        index++;
      }
    }

    foreach (Card c in deck)
    {
      Console.WriteLine($"{c.Rank}{c.Suit}");
    }
  }
}
