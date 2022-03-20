using System;
using System.Collections.Generic;

namespace TextBasedGame
{
    public class Place
    {
        //this class is to define a place
        private String PlaceName; //the name of the Place 
        //Directions
        private Place PlaceToNorth; //the place north to current place, if it doesn't have any, it should be null
        private Place PlaceToSouth;
        private Place PlaceToEast;
        private Place PlaceToWest;
        private Place PlaceToNorthEast;
        private Place PlaceToSouthEast;
        private Place PlaceToSouthWest;
        private Place PlaceToNorthWest;
        private Place PlaceUp;
        private Place PlaceDown;

        private String Description; //description of the place
        private String EventDescription; //this is used for when want to set the scene; for example: "You enter a Shed that is $Description", "You see a house with ... $Description"
        protected HashSet<Item> itemsInPlace; //items that are present in the place, these can be assets as well; eg: car,grass,rock
        protected HashSet<Place> ReachablePlaces;// Places that are reachable from this place
        public Place(
            String PlaceName, Place PlaceToNorth, Place PlaceToSouth, Place PlaceToEast,
            Place PlaceToWest, String Description,
            String EventDescription, Place PlaceUp = null, Place PlaceDown = null,
            Place PlaceToNorthEast = null, Place PlaceToSouthEast = null,
            Place PlaceToSouthWest = null, Place PlaceToNorthWest = null
            )
        {
            this.PlaceName = PlaceName;

            this.PlaceToNorth = PlaceToNorth;
            this.PlaceToSouth = PlaceToSouth;
            this.PlaceToEast = PlaceToEast;
            this.PlaceToWest = PlaceToWest;

            this.PlaceToNorthEast = PlaceToNorthEast;
            this.PlaceToSouthEast = PlaceToSouthEast;
            this.PlaceToSouthWest = PlaceToSouthWest;
            this.PlaceToNorthWest = PlaceToNorthWest;

            this.Description = Description;
            this.EventDescription = EventDescription;

            this.PlaceUp = PlaceUp;
            this.PlaceDown = PlaceDown;

            this.itemsInPlace = new HashSet<Item>();
            this.ReachablePlaces = new HashSet<Place>();
            
            //* Setting up reachable places
            if (hasDown())
                setReachablePlaces(PlaceDown);
            if (hasUp())
                setReachablePlaces(PlaceUp);

            if (hasEast())
                setReachablePlaces(PlaceToEast);
            if (hasWest())
                setReachablePlaces(PlaceToWest);
            if (hasNorth())
                setReachablePlaces(PlaceToNorth);
            if (hasSouth())
                setReachablePlaces(PlaceToSouth);

            if (hasNorthEast())
                setReachablePlaces(PlaceToNorthEast);
            if (hasNorthWest())
                setReachablePlaces(PlaceToNorthWest);
            if (hasSouthEast())
                setReachablePlaces(PlaceToSouthEast);
            if (hasSouthWest())
                setReachablePlaces(PlaceToSouthWest);
        }

        //gets the name of the place
        public String getPlaceName()
        {
            return PlaceName;
        }
        //gets the name of the place to north
        public Place _PlaceToNorth
        {
           get { return PlaceToNorth; } set { PlaceToNorth = value; }
        }
        //gets the name of the place to south
        public Place _PlaceToSouth
        {
            get { return PlaceToSouth; } set { PlaceToSouth = value; }
        }
        //gets the name of the place to east

        public Place _PlaceToEast
        {
            get { return PlaceToEast; } set { PlaceToEast = value; }
        }

        //gets the name of the place to west

        public Place _PlaceToWest
        {
            get { return PlaceToWest; } set { PlaceToWest = value; }
        }
        //gets description of a place
        public String getDescription()
        {
            return Description;
        }
        //gets eventDescription; this should be called when the players moves to a different place
        public String getEventDescription()
        {
            return EventDescription;
        }
        public void setEventDescription(String str)
        {
            EventDescription = str;
        }
        public void setDescription(String desc)
        {
            this.Description = desc;
        }
        public bool hasNorth()
        {
            return !(PlaceToNorth == null);
        }
        public bool hasSouth()
        {
            return !(PlaceToSouth == null);
        }
        public bool hasEast()
        {
            return !(PlaceToEast == null);
        }
        public bool hasWest()
        {
            return !(PlaceToWest == null);

        }

        public bool hasNorthEast()
        {
            return !(PlaceToNorthEast == null);
        }
        public bool hasSouthEast()
        {
            return !(PlaceToSouthEast == null);
        }
        public bool hasNorthWest()
        {
            return !(PlaceToNorthWest == null);
        }
        public bool hasSouthWest()
        {
            return !(PlaceToSouthWest == null);
        }


        public bool hasUp()
        {
            return !(PlaceUp == null);
        }
        public bool hasDown()
        {
            return !(PlaceDown == null);
        }

        public HashSet<Place> getReachablePlaces(){
            return ReachablePlaces;
        }
        //prints out all Places that are reachable from this place
        public String printReachablePlaces()
        {
            String reachablePlaces = "";
            foreach (Place x in ReachablePlaces)
            {
                reachablePlaces += x.getPlaceName() + "\n";
                //removes the last semicolon
                reachablePlaces=reachablePlaces.Remove(reachablePlaces.Length - 1);
            }
            return reachablePlaces;
        }
        public void setReachablePlaces(Place place)
        {
            ReachablePlaces.Add(place);
        }
        //adds items to place
        public void addItemToPlace(Item item)
        {
            try
            {
                itemsInPlace.Add(item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //checks if a specific place(in parameter) is reachable from this place
        public bool isParmPlaceReachable(Place place)
        {
            return ReachablePlaces.Contains(place);
        }
        //checks if an item exists in current place
        public bool checkItemIsHere(Item item)
        {
            return itemsInPlace.Contains(item);
        }
        //removes an item form current place
        public void removeItemFromPlace(Item item)
        {
            if (checkItemIsHere(item))
            {
                itemsInPlace.Remove(item);
            }
            else
            {
                Console.WriteLine("There is no such item in current place");
            }
        }



        public Place _PlaceToNorthEast { get { return PlaceToNorthEast; } set { PlaceToNorthEast = value; } }
        public Place _PlaceToSouthEast { get { return PlaceToSouthEast; } set { PlaceToSouthEast = value; } }
        public Place _PlaceToSouthWest { get { return PlaceToSouthWest; } set { PlaceToSouthWest = value; } }
        public Place _PlaceToNorthWest { get { return PlaceToNorthWest; } set { PlaceToNorthWest = value; } }
        public Place _PlaceUp { get { return PlaceUp; } set { PlaceUp = value; } }
        public Place _PlaceDown { get { return PlaceDown; } set { PlaceDown = value; } }
    }
}