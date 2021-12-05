using System;
using System.Collections.Generic;

namespace TextBasedGame{
    public class Commands{
        protected Command _Inspect;
        protected Command _Look;
        protected Command _Take;
        protected Command _Drop;
        private Dictionary<Command, String[]> _Abbrevs;
        private List<Command> _Commands; 

        public Commands()
        {
            _Commands = new List<Command>();
            _Abbrevs = new Dictionary<Command, string[]>();
            //inspect command
            {
            String[] InspectAbrevs={"inspect","examine","look at", "check", "look inside"};
            _Inspect = new Command("inspect",InspectAbrevs, "");
            _Inspect.setHelp($"This command Allows you to examine an item closely.\nIt has following Abbreviations: {_Inspect.printAbbreviation()}");
            _Abbrevs.Add(_Inspect,InspectAbrevs);
            _Commands.Add(_Inspect);
            }
            //Look command
            {
            String[] lookAbrevs={"l","look", "look around"};
            _Look = new Command("look",lookAbrevs, "");
            _Look.setHelp($"This command Allows you to look around.\nIt has following Abbreviations: {_Look.printAbbreviation()}");
            _Abbrevs.Add(_Look,lookAbrevs);
            _Commands.Add(_Look);
            }
        }

        public Command Inspect { get{return _Inspect;} set{_Inspect = value;} }
        public Command Look { get{return _Look;} set{_Look = value;} }

        public Dictionary<Command, String[]> Abbreviations {get{return _Abbrevs;} set{_Abbrevs=value;}}
        public List<Command> commands{get{return _Commands;}set{_Commands=value;}}
    }
}