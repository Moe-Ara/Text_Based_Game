using System;

namespace TextBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameName gameName= new GameName();
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine(gameName.getGameNameSpooky());
            Console.WriteLine("\n\n");
            WelcomingPlayer welcomingPlayer = new WelcomingPlayer();
            Player player = welcomingPlayer._player;
            Map initMap = welcomingPlayer._getIntializedMap;
        }
    }
}
