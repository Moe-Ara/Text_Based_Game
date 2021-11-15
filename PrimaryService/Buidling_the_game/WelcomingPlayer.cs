using System;

namespace TextBasedGame
{
    public class WelcomingPlayer
    {
        private GetUserInput _GetUserInput;
        private Map _IntializedMap;
        private Player _Player;
        private String _WelcomingMessage = "Welcome Player, This is our humble little Project that we are proud to present to you in this Form\n" +
        "This Game is dedicated to my Friends who always support me, Unborn Children who have been my biggest source of motivation and to my Mother who always believes in me, even when I don't" +
        "\n══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════ \n" +
        "But, enough about me for now;\nTell us about yourself Player";

        public WelcomingPlayer()
        {
            _GetUserInput=new GetUserInput();
            //? Printing the welcoming message
            Console.WriteLine(_WelcomingMessage);
            //? Setting up userName
            String Response = "no";
            String UserName="";
            while (!(Response.Equals("yes")))
            {
                Console.WriteLine("With which Name would you like us to call you?");
                UserName = _GetUserInput.getUserInput();
                if(String.IsNullOrEmpty(UserName)){
                    UserName="Player";
                }
                UserName= char.ToUpper(UserName[0])+UserName.Substring(1);
                Console.WriteLine($"Do You want us to call you {UserName} [default:yes]\n");
                Response = _GetUserInput.getUserInput().ToLower();
                //check if user didn't enter any input
                if(String.IsNullOrEmpty(Response)){
                    Response="yes";
                }
                //check if user entered abbreviations to no/yes
                if (Response[0] == 'n')
                {
                    Response = "no";
                }
                else if (Response[0] == 'y')
                {
                    Response = "yes";
                }
                else
                {
                    Console.WriteLine("Sorry, We couldn't understand that");
                }
            }
            Console.WriteLine($"Welcome To the 'game name' {UserName}. We hope you are ready");
            //?Initializing Map
            this._IntializedMap = new Map();
            //?Creating Player
            this._Player = new Player(UserName, "Female", "You Have the looks of young Woman, in her mid-twenties probably." +
           " Your short Black hair is tied in a practical knot on the back of your head. Your dark skin only brings the beauty of your green eyes.", _IntializedMap._Start);

        }

        public Map _getIntializedMap { get { return _IntializedMap; } }
        public Player _player { get { return _Player; } set { _Player = value; } }

        public String _welcomingMessage { get { return _WelcomingMessage; } set { _WelcomingMessage = value; } }

    }

}