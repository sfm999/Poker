using Poker.Models;

class Startup
{
  static void Main(string[] args)
  {
    // Welcome message
    Console.WriteLine("Welcome to 5-hand Poker!");

    Suit[] suits = { Suit.Spade, Suit.Club, Suit.Heart, Suit.Diamond };
    Rank[] ranks = 
            {
                Rank.Ace  , Rank.Two  , Rank.Three,
                Rank.Four , Rank.Five , Rank.Six,
                Rank.Seven, Rank.Eight, Rank.Nine,
                Rank.Ten  , Rank.Jack , Rank.Queen,
                Rank.King
            };

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
      Console.WriteLine($"{c.GetRank()}{c.GetSuit()}");
    }
  }
}
