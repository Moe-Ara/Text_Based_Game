using System;
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
        
        public Map()
        {
            //setting up the first place which is the starting point; it is called "driveway"
            TextBasedGame.Start st =new TextBasedGame.Start();
            st.PlaceToEast=this.FrontLawn;
            this.Start= new Place(st.PlaceName,null,null,st.PlaceToEast,null,st.PlaceDesc,st.EventDescript);

            



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