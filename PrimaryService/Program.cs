using System;
namespace TextBasedGame
{
    class Program
    {            //* Creating a path to map the player's movement
        public static Path playerPath = new Path();
        public static Map InitializedMap = new Map();
        public static Commands GameCommands = new Commands();
        public static Inventory PlayersInventory = new Inventory();

        //* Welcome Player and determine their characteristics
        public static WelcomingPlayer InitiatingPlayer = new WelcomingPlayer();

        static void Main(string[] args)
        {
            //* these are symbols that we want to get rid of from the user's input
            String[] unusableSymboles = { ",", ".", "!", "?", ";", ":", "\'", "\"" };
            //* To Print the Game Name in ascci
            GameName gameName = new GameName();
            //* clear the console at the start
           // Console.Clear();
            //* Printing the Game Name
            Console.WriteLine("\n\n");
            Console.WriteLine(gameName.getGameNameSpooky());
            Console.WriteLine("\n\n");
            //* Create the player
            Player player = InitiatingPlayer._player;
            //* Initialize command interpreter
            InterpretCommand interpretCommand = new InterpretCommand();
            //* Custom Class to get the user input
            GetUserInput getUserInput = new GetUserInput();
            //* Easter eggs and secert messages
            Secrets secrets = new Secrets();
            //* Setting up the first place on the map
            playerPath.AddAtLast(player.getPlayerscurrentPlace());
            //* Describing the start point 
            System.Console.WriteLine(playerPath.getLastPlace().getEventDescription());
            //* This will store the user's input later
            String str = null;
            //* Endless loop, until the user types 'bye' or 'quit'
            while (true)
            {
                //* Take the user's input and convert to lower case
                str = getUserInput.getUserInput().ToLower();
                //* check if user entered nothing
             //* check if the user has entered something
            if (str == "") { System.Console.WriteLine("You have to enter a command, try 'help' or 'h'");continue; }
                //* delete all unusable symbols from the user's input
                foreach (String x in unusableSymboles)
                {
                    if (str.Contains(x))
                        str = str.Replace(x, "");
                }
                //* check if the user wants to quit the game
                if (str.Contains("quit") || str.Contains("bye"))
                {
                    break;
                }
                //* Check for secret messages
                bool s = secrets.CheckForSecretInput(str, player);
                if (s == true)
                    continue;

                String Answer=interpretCommand.Interpreter(str);
                System.Console.WriteLine(Answer);
            }
            System.Console.WriteLine("Goodbye brave adventurer, may we see each other in another life");
        }
    }
}
