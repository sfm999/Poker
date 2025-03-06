namespace Poker.Models
{
    public class Card
    {
        private Suit suit;
        private Rank rank; // Change to string to allow "10"

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public char GetSuit() => suit.GetSuitIcon();

        public string GetRank() => rank.GetRankName();

        public override string ToString() => $"{GetRank()}{GetSuit()}";
    }
}
