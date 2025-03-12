using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Models
{
    public class Hand
    {
        public List<Card> Cards { get; private set; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card) => Cards.Add(card);

        public void DisplayCards() => Console.WriteLine(string.Join(" ", Cards));
    }
}
