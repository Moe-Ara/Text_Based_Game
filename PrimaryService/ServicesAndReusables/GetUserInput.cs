using System;

namespace TextBasedGame{
    class GetUserInput{
        public string getUserInput(){
            Console.WriteLine(" ");
            Console.Write("> ");
            string input= Console.ReadLine();
            Console.WriteLine(" ");
            return input;
        }
    }
}