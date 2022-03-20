using System;
using System.Collections.Generic;

namespace TextBasedGame
{
    public class Commands
    {
        /*
        * This Class is used to initialize all commands in the game
        * In this class we can add commands to the game
        * Each attribute is a command
        */
        protected Command _Inspect;
        protected Command _Look;
        protected Command _Take;
        protected Command _Drop;
        protected Command _Jump;
        protected Command _Go;
        protected Command _Enter;
        protected Command _Burn;
        protected Command _Break;
        protected Command _Use;
        protected Command _Open;
        //protected Command _Help;
        //private Dictionary<Command, String[]> _Abbrevs;
        private List<Command> _Commands; //List of all commands 

        public Commands()
        {
            _Commands = new List<Command>();
            //  _Abbrevs = new Dictionary<Command, string[]>();

            //inspect command
            {
                String[] InspectAbrevs = { "inspect", "examine", "look at", "check", "look inside" };
                _Inspect = new Command("inspect", InspectAbrevs, "");
                _Inspect.setHelp($"This command Allows you to examine an item closely.\nIt has following Abbreviations: {_Inspect.printAbbreviation()}");
                //_Abbrevs.Add(_Inspect,InspectAbrevs);
                _Commands.Add(_Inspect);
            }

            //Look command
            {
                String[] lookAbrevs = { "l", "look", "look around" };
                _Look = new Command("Look", lookAbrevs, "");
                _Look.setHelp($"This command Allows you to look around.\nIt has following Abbreviations: {_Look.printAbbreviation()}");
                //_Abbrevs.Add(_Look,lookAbrevs);
                _Commands.Add(_Look);
            }

            //Take Command
            {
                String[] takeAbrevs = { "take", "pick", "get" };
                _Take = new Command("Take", takeAbrevs, "");
                _Take.setHelp($"This command Allows you to pick an item from your environment.\nIt has following Abbreviations: {_Take.printAbbreviation()}");
                //_Abbrevs.Add(_Look,lookAbrevs);
                _Commands.Add(_Take);
            }

            //Drop Command
            {
                String[] dropAbrevs = { "drop", "throw", "remove" };
                _Drop = new Command("Drop", dropAbrevs, "");
                _Drop.setHelp($"This command Allows you to drop an item from your inventory.\nIt has following Abbreviations: {_Drop.printAbbreviation()}");
                //_Abbrevs.Add(_Look,lookAbrevs);
                _Commands.Add(_Drop);
            }

            //Jump Command
            {
                String[] jumpAbrevs = { "jump", "hop", "jmp" };
                _Jump = new Command("Jump", jumpAbrevs, "");
                _Jump.setHelp($"This command Allows you to jump.\nIt has following Abbreviations: {_Jump.printAbbreviation()}");
                //_Abbrevs.Add(_Look,lookAbrevs);
                _Commands.Add(_Jump);
            }

            //Go Command
            {
                String[] goAbrevs = { "go", "walk" };
                _Go = new Command("Go", goAbrevs, "");
                _Go.setHelp($"This command Allows you to move around.\nIt has following Abbreviations: {_Go.printAbbreviation()}");
                //_Abbrevs.Add(_Look,lookAbrevs);
                _Commands.Add(_Go);
            }

            //Enter Command
            {
                String[] enterAbrevs = { "go inside", "enter" };
                _Enter = new Command("Enter", enterAbrevs, "");
                _Enter.setHelp($"This command has following Abbreviations: {_Enter.printAbbreviation()}");
                //_Abbrevs.Add(_Look,lookAbrevs);
                _Commands.Add(_Enter);
            }
                        
            //Burn Command
            {
                String[] burnAbrevs = { "Burn", "light up" };
                _Burn = new Command("Burn", burnAbrevs, "");
                _Burn.setHelp($"This command Allows you to burn inflammable items.\nhas following Abbreviations: {_Burn.printAbbreviation()}");
                //_Abbrevs.Add(_Look,lookAbrevs);
                _Commands.Add(_Burn);
            }

            //Break Command
            {
                String[] breakAbrevs = { "Break", "smash" };
                _Break = new Command("enter", breakAbrevs, "");
                _Break.setHelp($"This command Allows you to break breakable items.\nhas following Abbreviations: {_Break.printAbbreviation()}");
                //_Abbrevs.Add(_Look,lookAbrevs);
                _Commands.Add(_Break);
            }

            //Use Command
            {
                String[] useAbrevs = {""};
                _Use = new Command("Use", useAbrevs, "");
                _Use.setHelp("This command has no abbreviations");
                //_Abbrevs.Add(_Look,lookAbrevs);
                _Commands.Add(_Use);
            }

            //Open Command
            {
                String[] openAbrevs={""};
                _Open = new Command("Open", openAbrevs,"help");
            }

            // //Help Command
            // {
            //     String[] helpAbrevs = {"help", "h"};
            //     _Help = new Command("Help", helpAbrevs, "");
            //     //_Abbrevs.Add(_Look,lookAbrevs);
            //     _Commands.Add(_Help);
            // }
        }

        public Command Inspect { get { return _Inspect; } set { _Inspect = value; } }
        public Command Look { get { return _Look; } set { _Look = value; } }
        public Command Take {get{return _Take;} set{_Take=value;}}
        public Command Drop {get{return _Drop;} set{_Drop=value;}}
        public Command Jump {get{return _Jump;} set{_Jump=value;}}
        public Command Go {get{return _Go;} set{_Go=value;}}
        public Command Enter {get{return _Enter;} set{_Enter=value;}}
        public Command Burn {get{return _Burn;} set{_Burn=value;}}
        public Command Break {get{return _Break;} set{_Break=value;}}
        public Command Use {get{return _Use;} set{_Use=value;}}
        //public Command Help {get{return _Help;} set{_Help=value;}}

        // public Dictionary<Command, String[]> Abbreviations {get{return _Abbrevs;} set{_Abbrevs=value;}}
        public List<Command> commands { get { return _Commands; } set { _Commands = value; } }
        public String PrintCommands(){
            String str="";
            foreach (Command cmd in commands){
                str+=cmd.getCommand() + "\n";
                }
            return str;
        }
    }
}