
using System.Diagnostics.CodeAnalysis;

namespace Poker.Models
{
    class Player
    {
        [SetsRequiredMembers]
        public Player(string name)
        {
            Name = name;
            Hand = new Hand([]);
        }

        public required string Name { get; init; }

        public Hand Hand { get; set; } = new Hand(new List<Card>());

        public void SetHand(Hand hand)
        {
            Hand = hand ?? throw new ArgumentNullException(nameof(hand), "Hand cannot be null.");
        }
        public void ClearHand() => Hand.ClearHand();

        public void DisplayHand() => Hand.DisplayHand();
    }
}
