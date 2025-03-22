using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Models
{
    class Dealer
    {
        private List<Player> players;
        public List<Player> Players
        {
            get
            {
                return players;
            }

            set
            {
                players = value;
            }
        }

        private int CurrentRound
        { get; set; }

        public Dealer(List<Player> players)
        {
            CurrentRound = 0;
            this.players = players;
        }
    }
}
