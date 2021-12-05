﻿using System;

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
            InterpretCommand interpretCommand= new InterpretCommand();
            GetUserInput getUserInput = new GetUserInput();
            System.Console.WriteLine("Input your first command here");
            String str=null;
            while(true){
                str=getUserInput.getUserInput().ToLower();
                if (str.Equals("exit")||str.Equals("quit")||str.Equals("Bye")){
                    break;
                }
            System.Console.WriteLine(interpretCommand.Interpreter(str));
            }
            System.Console.WriteLine("Goodbye brave adventurer, may we see eachother in another life");
        }
    }
}
