using System;
using System.Collections.Generic;

//* This class has only one public function and it is to be used to interpret the user's input
namespace TextBasedGame
{
    class InterpretCommand
    {
        private Command command;
        private Item item;
        private Place place;
        //* get the all the commands in the game

        public String Interpreter(String str)
        {
            command =null;
            item=null;
            place=null;
            
            //* if they did, we take their input and convert it to a hashset that contains every single word in their input
            HashSet<String> strings = new HashSet<string>(str.Split(" "));
            //initialize some helper variables
            // Command command=null;
            String result = "I couldn't understand that, please type 'help' or 'h' for help";
            //* check for every command in the game if the user's input contains it or contains any of its abbriviation
            foreach (Command cmd in Program.GameCommands.commands)
            {
                foreach (string abr in cmd.getAbbreviation())
                {
                    if (strings.Contains(abr))
                    {
                        command = cmd;
                        break;
                    }
                }
                //* check if we have already found the command, if so, we break to save time
                if (command != null)
                    break;
            }
            // //* check if we haven't found the command
            // if (command == null)
            //     result = "I couldn't understand you command, please type 'help' or 'h' for help";

            //* Show Inventory
            if(strings.Contains("inventory") && !(strings.Contains("from")||strings.Contains("to"))){
                result= Program.InitiatingPlayer._player.printMyInventory();
            }

            //* Check if the user asks for help
            if (strings.Contains("help") || strings.Contains("h"))
            {
                //? to print the commands
                result = "You can use the following commands: \n" + Program.GameCommands.PrintCommands();
                //? get help for specific places/iteams/commands
                if (place != null)
                {
                    result = place.getDescription();
                }
                if (item != null)
                {
                    result = item.getDescription();
                }
                if (command != null)
                {
                    result = command.getHelp();
                }
            }

            //* User wants to move using the 'Go' command
            if (command == Program.GameCommands.Go)
            {
                result = "Where to ?";
                //? specific place
                if (place != null)
                {
                    result = "Where is that? You might not have access to that place";
                    //? go to place
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().getReachablePlaces().Contains(place))
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(place);
                        result = place.getEventDescription();
                        Program.playerPath.AddAtLast(place);
                    }
                }
                //? directions
                //~ left
                if (strings.Contains("left") || strings.Contains("west") || strings.Contains("w"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasWest())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace().getPlaceToWest());
                        result = place.getEventDescription();
                    }
                }
                //~ right
                if (strings.Contains("right") || strings.Contains("east") || strings.Contains("e"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasEast())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace().getPlaceToEast());
                        result = place.getEventDescription();
                    }
                }
                //~ north
                if (strings.Contains("forward") || strings.Contains("north") || strings.Contains("n"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasNorth())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace().getPlaceToNorth());
                        result = place.getEventDescription();
                    }
                }
                //~ south
                if (strings.Contains("south") || strings.Contains("s"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasSouth())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace().getPlaceToSouth());
                        result = place.getEventDescription();
                    }
                }
                //~ northeast
                if (strings.Contains("northeast") || strings.Contains("ne"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasNorthEast())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace()._PlaceToNorthEast);
                        result = place.getEventDescription();
                    }
                }
                //~ northwest
                if (strings.Contains("northwest") || strings.Contains("nw"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasNorthWest())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace()._PlaceToNorthWest);
                        result = place.getEventDescription();
                    }
                }
                //~ southeast
                if (strings.Contains("southeast") || strings.Contains("se"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasSouthEast())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace()._PlaceToSouthEast);
                        result = place.getEventDescription();
                    }
                }
                //~ southwest
                if (strings.Contains("southwest") || strings.Contains("sw"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasSouthWest())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace()._PlaceToSouthWest);
                        result = place.getEventDescription();
                    }
                }
                //~ back
                if (strings.Contains("back"))
                {
                    if (Program.playerPath.getFirstPlace() != Program.playerPath.getLastPlace())
                    {
                        Program.playerPath.RemoveLast();
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.playerPath.getFirstPlace());
                        result = place.getDescription();
                    }
                }
                //~ up
                if (strings.Contains("up"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasUp())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace()._PlaceUp);
                        result = place.getEventDescription();
                    }
                }
                //~ down
                if (strings.Contains("down"))
                {
                    if (Program.InitiatingPlayer._player.getPlayerscurrentPlace().hasDown())
                    {
                        Program.InitiatingPlayer._player.setPlayerscurrentPlace(Program.InitiatingPlayer._player.getPlayerscurrentPlace()._PlaceDown);
                        result = place.getEventDescription();
                    }
                }
                Program.playerPath.AddAtLast(Program.InitiatingPlayer._player.getPlayerscurrentPlace());
            }

            //* Users wants to use "Look" command
            if (command == Program.GameCommands.Look)
            {
                //? look around
                result = Program.InitiatingPlayer._player.getPlayerscurrentPlace().getDescription();
                //? look at item 
                if (item != null && !(strings.Contains("around")))
                {
                    result = item.getDescription();
                }
                if (place != null && !(strings.Contains("around")))
                {
                    result = place.getDescription();
                }

            }

            //* Users wants to use "Inspect" command
            if (command == Program.GameCommands.Inspect)
            {
                result = "What exactly do you want to inspect ?";
                //? inspect at item 
                if (item != null)
                {
                    result = item.getDescription();
                }
            }


            //! for now, if we found the command we return it's help statement, this will be changed later
            //result = command.getHelp();
            return result;
        }
    }
}