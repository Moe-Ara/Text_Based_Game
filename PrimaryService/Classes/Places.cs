using System;
using System.Collections.Generic;
using TextBasedGame;
namespace TextBasedGame
{
    public class Place
    {
        //this class is to define a place
        private String PlaceName; //the name of the Place 
        private String PlaceToNorth; //the Name of the place north to it
        private String PlaceToSouth;
        private String PlaceToEast;
        private String PlaceToWest;
        private String Description; //description of the place
        private String EventDescription; //this is used for when want to set the scene; for example: "You enter a Shed that is $Description", "You see a house with ... $Description"
        protected HashSet<Item> itemsInPlace; //items that are present in the place, these can be assets as well; eg: car,grass,rock
        public Place(String PlaceName, String PlaceToNorth, String PlaceToSouth, String PlaceToEast, String PlaceToWest, String Description,String EventDescription)
        {
            this.PlaceName = PlaceName;
            this.PlaceToNorth = PlaceToNorth;
            this.PlaceToSouth = PlaceToSouth;
            this.PlaceToEast = PlaceToEast;
            this.PlaceToWest = PlaceToWest;
            this.Description= Description;
            this.EventDescription = EventDescription;
            this.itemsInPlace = new HashSet<Item>();
        }

        //gets the name of the place
        public String getPlaceName()
        {
            return PlaceName;
        }
        //gets the name of the place to north
        public String getPlaceToNorth()
        {
            return PlaceToNorth;
        }
        //gets the name of the place to south
        public String getPlaceToSouth()
        {
            return PlaceToSouth;
        }
        //gets the name of the place to east

        public String getPlaceToEast()
        {
            return PlaceToEast;
        }

        //gets the name of the place to west

        public String getPlaceToWest()
        {
            return PlaceToWest;
        }
        //gets description of a place
        public String getDescription()
        {
            return Description;
        }
        //gets eventDescription; this should be called when the players moves to a different place
        public String getEventDescription(){
            return EventDescription;
        }
        public void setDescription(String desc)
        {
            this.Description = desc;
        }
        public bool hasNorth()
        {
            return !(PlaceToNorth.Equals(""));
        }
        public bool hasSouth()
        {
            return !(PlaceToSouth.Equals(""));
        }
        public bool hasEast()
        {
            return !(PlaceToEast.Equals(""));
        }
        public bool hasWest()
        {
            return !(PlaceToWest.Equals(""));
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



    }
}