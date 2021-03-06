using System;
namespace TextBasedGame
{
    public class GameName
    {
        private String _CustomGameName;
        private String _GameNameBloody = @"

▄▄▄█████▓ ██░ ██ ▓█████     ██▓     ▒█████    ██████ ▄▄▄█████▓    ▄████▄   ██░ ██  ██▓ ██▓    ▓█████▄ 
▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓██▒    ▒██▒  ██▒▒██    ▒ ▓  ██▒ ▓▒   ▒██▀ ▀█  ▓██░ ██▒▓██▒▓██▒    ▒██▀ ██▌
▒ ▓██░ ▒░▒██▀▀██░▒███      ▒██░    ▒██░  ██▒░ ▓██▄   ▒ ▓██░ ▒░   ▒▓█    ▄ ▒██▀▀██░▒██▒▒██░    ░██   █▌
░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ▒██░    ▒██   ██░  ▒   ██▒░ ▓██▓ ░    ▒▓▓▄ ▄██▒░▓█ ░██ ░██░▒██░    ░▓█▄   ▌
  ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░██████▒░ ████▓▒░▒██████▒▒  ▒██▒ ░    ▒ ▓███▀ ░░▓█▒░██▓░██░░██████▒░▒████▓ 
  ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░   ░ ▒░▓  ░░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░  ▒ ░░      ░ ░▒ ▒  ░ ▒ ░░▒░▒░▓  ░ ▒░▓  ░ ▒▒▓  ▒ 
    ░     ▒ ░▒░ ░ ░ ░  ░   ░ ░ ▒  ░  ░ ▒ ▒░ ░ ░▒  ░ ░    ░         ░  ▒    ▒ ░▒░ ░ ▒ ░░ ░ ▒  ░ ░ ▒  ▒ 
  ░       ░  ░░ ░   ░        ░ ░   ░ ░ ░ ▒  ░  ░  ░    ░         ░         ░  ░░ ░ ▒ ░  ░ ░    ░ ░  ░ 
          ░  ░  ░   ░  ░       ░  ░    ░ ░        ░              ░ ░       ░  ░  ░ ░      ░  ░   ░    
                                                                 ░                             ░   
        ";
        private String _GameNameSpooky = @"
    ███        ▄█    █▄       ▄████████       ▄█        ▄██████▄     ▄████████     ███           ▄████████    ▄█    █▄     ▄█   ▄█       ████████▄  
▀█████████▄   ███    ███     ███    ███      ███       ███    ███   ███    ███ ▀█████████▄      ███    ███   ███    ███   ███  ███       ███   ▀███ 
   ▀███▀▀██   ███    ███     ███    █▀       ███       ███    ███   ███    █▀     ▀███▀▀██      ███    █▀    ███    ███   ███▌ ███       ███    ███ 
    ███   ▀  ▄███▄▄▄▄███▄▄  ▄███▄▄▄          ███       ███    ███   ███            ███   ▀      ███         ▄███▄▄▄▄███▄▄ ███▌ ███       ███    ███ 
    ███     ▀▀███▀▀▀▀███▀  ▀▀███▀▀▀          ███       ███    ███ ▀███████████     ███          ███        ▀▀███▀▀▀▀███▀  ███▌ ███       ███    ███ 
    ███       ███    ███     ███    █▄       ███       ███    ███          ███     ███          ███    █▄    ███    ███   ███  ███       ███    ███ 
    ███       ███    ███     ███    ███      ███▌    ▄ ███    ███    ▄█    ███     ███          ███    ███   ███    ███   ███  ███▌    ▄ ███   ▄███ 
   ▄████▀     ███    █▀      ██████████      █████▄▄██  ▀██████▀   ▄████████▀     ▄████▀        ████████▀    ███    █▀    █▀   █████▄▄██ ████████▀  
                                             ▀                                                                                 ▀                    
        ";
        public GameName() { }
        public String getGameNameBloody()
        {
            return _GameNameBloody;
        }
        public String getGameNameSpooky()
        {
            return _GameNameSpooky;
        }

        public String getCustomGameName(){
            return _CustomGameName;
        }
        public void setCustomGameName(string gameName){
            _CustomGameName=gameName;
        }

    }
}