using System;
using System.Collections.Generic;

namespace TextBasedGame
{
    public class Command
    {
        private String command; //the command itself
        private String[] Abbreviation; //abbreviation of command
        //private HashSet<String> Args; //argumanets to a command
        private String Help; //Description of What Command Can Do
        public Command(String _Command, String[] _Abbreviation, String Help)
        {
            Abbreviation = new String[_Abbreviation.Length];
            this.command = _Command;
            this.Abbreviation = _Abbreviation;
            this.Help = Help;
        }
        //Getters
        public String getCommand()
        {
            return command;
        }
        public String[] getAbbreviation()
        {
            return Abbreviation;
        }
        public String printAbbreviation()
        {
            String Abbreviations = "";
            foreach (String x in Abbreviation){
                Abbreviations+= x + "; ";
                Abbreviations.Remove(Abbreviations.Length-1);
            }
            return Abbreviations;

        }
        public String getHelp()
        {
            return Help;
        }
        //Setters
        public void setHelp(String help)
        {
            this.Help = help;
        }
        public void setCommand(String command)
        {
            this.command = command;
        }

    }
}
