using System;

namespace TextBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\n");
            WelcomingPlayer welcomingPlayer = new WelcomingPlayer();
            Player player = welcomingPlayer._player;
            Map initMap = welcomingPlayer._IntializedMap;
        }
    }
}
