using Poker.Models;

class Startup
{
  static void Main(string[] args)
  {
        // Welcome message
        Console.WriteLine("Welcome to 5-hand Poker!");

        Deck deck = new Deck();

        deck.Shuffle();

        int playerCount = 5;
        int handSize = 5;

        List<Player> players = new();
        string[] names = { "Bob", "Jane", "Larry", "Kate", "Moe" };
        for(int i = 0; i < playerCount; i++)
        {
            players.Add(new Player(names[i]));
            players[i].SetHand(new Hand(
                deck.DealHand(handSize: handSize, playerCount: playerCount, playerNumber: i))
            );
        }

        foreach (Player player in players)
        {
            Console.Write($"{player.Name}: ");
            player.DisplayHand();
        }
    }
}
