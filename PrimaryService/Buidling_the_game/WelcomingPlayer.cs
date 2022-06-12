using System;

namespace TextBasedGame
{
    public class WelcomingPlayer
    {
        private GetUserInput _GetUserInput;
        private Player _Player;
        private String _WelcomingMessage = "Greetings fellow player. Behold our new Text-based adventure."
                + " We hope that you are ready and as excited as we are to try it out"
                + "\nThis game is biggner-friendly so don't worry if it's your first time (that's what she said ;p) "
                + "you can always type help to get help ;). Good Luck\n" +
        "This Game is dedicated to my Friends who have always supported me, Ann and El who have been my biggest source of motivation and to my Mother who always believes in me, even when I don't" +
        "\n══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════ \n" +
        "But, enough about me for now;\nTell us about yourself Player";

        public WelcomingPlayer()
        {
            _GetUserInput = new GetUserInput();
            //? Printing the welcoming message
            Console.WriteLine(_WelcomingMessage);
            //? Setting up userName
            String Response = "no";
            String UserName = "";
            while (!(Response.Equals("yes")))
            {
                Console.WriteLine("First of all, how shall thee be called upon ??");
                UserName = _GetUserInput.getUserInput();
                if (String.IsNullOrEmpty(UserName))
                {
                    UserName = "Player";
                }
                UserName = char.ToUpper(UserName[0]) + UserName.Substring(1);
                Console.WriteLine($"Do You want us to call you {UserName} [default:yes]\n");
                Response = _GetUserInput.getUserInput().ToLower();
                //check if user didn't enter any input
                if (String.IsNullOrEmpty(Response))
                {
                    Response = "yes";
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
            //? Creating Player
            this._Player = new Player(UserName, "Female", "You Have the looks of young Woman, in her mid-twenties probably." +
           " Your short Black hair is tied in a practical knot on the back of your head. Your dark skin only brings the beauty of your green eyes.", Program.InitializedMap._Start,Program.PlayersInventory);

        }
        public Player _player { get { return _Player; } set { _Player = value; } }

        public String _welcomingMessage { get { return _WelcomingMessage; } set { _WelcomingMessage = value; } }

    }

}