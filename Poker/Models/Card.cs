
namespace poker.Models
{
  class Card
  {
    public char Suit { get; }
    public char Rank { get; }

    public Card(char suit, char rank)
    {
      Suit = suit;
      Rank = rank;
    }
  }
}
