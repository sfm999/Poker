namespace Poker.Models
{
    public enum Suit
    {
        Spade   = '\u2660', // ♠
        Club    = '\u2663', // ♣
        Heart   = '\u2665', // ♥
        Diamond = '\u2666'  // ♦
    }

    static class SuitExtensions
    {
        public static char GetSuitIcon(this Suit suit)
        {
            return (char)suit;
        }
    }
}
