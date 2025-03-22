namespace Poker.Models
{
    public enum Round
    {
        PreFlop,
        Flop,
        Turn,
        River
    }

    static class RoundExtensions
    {
        public static int GetRoundNumber(this Round round)
        {
            return (int)round;
        }
    }
}
