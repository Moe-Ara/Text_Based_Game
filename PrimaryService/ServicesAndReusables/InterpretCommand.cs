using System;
using System.Collections.Generic;

//* This class has only one public function and it is to be used to interpret the user's input
namespace TextBasedGame{
    class InterpretCommand{
        //*get the all the commands in the game
        private Commands GameCommands= new Commands();
       public String Interpreter(String str){
           //* check if the user has entered something
           if (str==""){return "You have to enter a command, try 'help' or 'h'";}
           //* if they did, we take their input and convert it to a hashset that contains every single word in their input
            HashSet<String> strings= new HashSet<string>(str.Split(" "));
            //initialize some helper variables
            Command command=null;
            String result= null;
            //* check for every command in the game if the user's input contains it or contains any of its abbriviation
            foreach (Command cmd in GameCommands.commands){
                foreach (string abr in cmd.getAbbreviation()){
                if (strings.Contains(abr)){
                    command = cmd;
                    break;
                }
                }
                //* check if we have already found the command, if so, we break to save time
                if (command !=null)
                    break;
            }
            //*check if we haven't found the command
            if (command==null)
                return "I couldn't understand you command, please type 'help' or 'h' for help";
            //! for now, if we found the command we return it's help statement, this will be changed later
            result=command.getHelp();
            return result;
        }
    }
}