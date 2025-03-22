using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Models
{
    class Hand
    {
        public List<Card> Cards { get; private set; }

        public Hand(List<Card> cards)
        {
            Cards = cards;
        }

        public void DisplayHand() => Console.WriteLine(string.Join(" ", Cards));

        public void ClearHand() => Cards.Clear();
    }
}
