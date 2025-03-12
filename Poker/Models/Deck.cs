using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Models
{
    public class Deck
    {
        Card[] cards;

        public Deck()
        {
            cards = new Card[52];
            PopulateCards();
        }

        public void PopulateCards()
        {
            Suit[] suits = { Suit.Spade, Suit.Club, Suit.Heart, Suit.Diamond };
            Rank[] ranks =
                    {
                Rank.Ace  , Rank.Two  , Rank.Three,
                Rank.Four , Rank.Five , Rank.Six,
                Rank.Seven, Rank.Eight, Rank.Nine,
                Rank.Ten  , Rank.Jack , Rank.Queen,
                Rank.King
            };
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards[index] = new Card(suits[i], ranks[j]);
                    index++;
                }
            }
        }

        public void DisplayAllCards()
        {
            foreach (Card c in cards)
                Console.WriteLine($"{c.GetRank()}{c.GetSuit()}");
        }

        public void Shuffle()
        {
            var rand = new Random();
            for (int i = cards.Length - 1; i > 1; i--)
            {
                int j = rand.Next(i);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public List<Card> DealHand(int handSize, int playerCount, int playerNumber)
        {
            List<Card> hand = new();
            for(int i = playerNumber; i < handSize*playerCount; i+=playerCount)
            {
                hand.Add(cards[i]);
            }

            return hand;
        }
    }
}
