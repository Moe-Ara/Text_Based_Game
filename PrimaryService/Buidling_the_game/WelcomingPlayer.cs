using System;

namespace TextBasedGame
{
    public class WelcomingPlayer
    {
        private Map IntializedMap;
        private Player player;
        private String WelcomingMessage = "Welcome Player, This is our humble little Project that we are proud to present to you in this Form\n" +
        "This Game is dedicated to my Friends who have supported me, Unborn Children who have been my biggest source of motivation and to my Mother who has always believed in me, even when I didn't" +
        "\n--------\n" +
        "But, enough about me now; tell us about yourself Player";

        public WelcomingPlayer()
        {
            //? Printing the welcoming message
            Console.WriteLine(WelcomingMessage);
            //? Setting up userName
            String Response = "no";
            String UserName="";
            while (!(Response.Equals("yes")))
            {
                Console.WriteLine("With which Name would you like us to call you?");
                UserName = Console.ReadLine();
                if(String.IsNullOrEmpty(UserName)){
                    UserName="Player";
                }
                UserName= char.ToUpper(UserName[0])+UserName.Substring(1);
                Console.WriteLine($"Do You want us to call you {UserName} [default:yes]");
                Response = Console.ReadLine().ToLower();
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
            this.IntializedMap = new Map();
            //?Creating Player
            this.player = new Player(UserName, "Female", "You Have the looks of young Woman, in her mid-twenties probably." +
           " Your short Black hair is tied in a practical knot on the back of your head. Your dark skin only brings the beauty of your green eyes.", IntializedMap._Start);

        }

        public Map _IntializedMap { get { return IntializedMap; } }
        public Player _player { get { return player; } set { player = value; } }

        public String _welcomingMessage { get { return WelcomingMessage; } set { WelcomingMessage = value; } }

    }

}