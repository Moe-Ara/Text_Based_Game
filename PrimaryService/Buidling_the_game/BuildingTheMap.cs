using System;
using System.Collections.Generic;
namespace TextBasedGame
{
    public class Map
    {
        protected Place Start;
        protected Place FrontLawn;
        protected Place House;
        protected Place Basement;
        protected Place Shed;
        protected Place Demonic_room;
        protected Place Kitchen;
        protected Place BackLawn;
        protected Place Field;
        protected Place SecondFloor;
        protected Place Attic;
        protected Place ParentsRoom;
        protected Place ChildrensRoom;
        protected Place Tunnel;

        private HashSet<Place> places= new HashSet<Place>();
        public Map()
        {
            //* Setting up the first place 'Start' which is the starting point; it is called "driveway"
            {
                this.Start = new Place("Drive Way", null, null, _FrontLawn, null, null, null);
                this.Start.setDescription("You see a big house to your North-East, it looks renovated and unlike the other houses, it looks like it was built not long ago.\n"
            + "You look at your car and you feel sorry for that poor piece of garbage standing in the middle of a narrow road, emitting heat and some smoke from its front end.\n"
            + "There is a passage to the east that leads to the house.");
                this.Start.setEventDescription($"It is really hard to see anything in this unsetteling darkness, However, {this.Start.getDescription()}");
                places.Add(this.Start);
                Asset MailBox= new Asset("Mailbox","Description","LongDescription");
                this.Start.addItemToPlace(MailBox);
            }
            //* Setting up the frontlawn
            {
                this.FrontLawn= new Place("Front Lawn", House,null,null,_Start,"You are at frontlawn","now you are at front lawn",null,null,null,Shed,null,BackLawn);
                places.Add(this.FrontLawn);
                

            }
            
            
            
            //* connecting map together
            {
                 this.Start._PlaceToEast=this.FrontLawn;
                 this.FrontLawn._PlaceToNorth=this.House;

            }





        }

        public Place _Start { get { return Start; } set { Start = value; } }
        public Place _FrontLawn { get { return FrontLawn; } set { FrontLawn = value; } }
        public Place _House { get { return House; } set { House = value; } }
        public Place _Basement { get { return Basement; } set { Basement = value; } }
        public Place _Shed { get { return Shed; } set { Shed = value; } }
        public Place _Demonic_room { get { return Demonic_room; } set { Demonic_room = value; } }
        public Place _Kitchen { get { return Kitchen; } set { Kitchen = value; } }
        public Place _BackLawn { get { return BackLawn; } set { BackLawn = value; } }
        public Place _Field { get { return Field; } set { Field = value; } }
        public Place _SecondFloor { get { return SecondFloor; } set { SecondFloor = value; } }
        public Place _Attic { get { return Attic; } set { Attic = value; } }
        public Place _ParentsRoom { get { return ParentsRoom; } set { ParentsRoom = value; } }
        public Place _ChildrensRoom { get { return ChildrensRoom; } set { ChildrensRoom = value; } }
        public Place _Tunnel { get { return Tunnel; } set { Tunnel = value; } }


    }

}