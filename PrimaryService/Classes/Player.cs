using System;
using System.Collections.Generic;

namespace TextBasedGame
{
    public class Player
    {
        //we can add player's level, player's health and player's Life status(are they alive) if we want to, but i will leave it for now
        private String name; //player's name
        private String sex; //player's sex
        private String Description; //player's Description (appearance)
        private Place MyOldPlace; //to be able to go back
        private Place MyCurrentPlace; //Player's current place
        private Inventory inventory; //player's inventory

        public Player(String name, String sex, String Description, Place MyCurrentPlace, Inventory inventory)
        {
            this.name = name;
            this.sex = sex;
            this.Description = Description;
            this.MyCurrentPlace = MyCurrentPlace;
            this.inventory = inventory;
        }
        public String getName() { return name; } //getter for Player Name
        public String getSex() { return sex; }     //getter for Player's sex

        public String getDescription() { return Description; }  //getter for player's description
        public Place getMycurrentPlace()    //getter to get the current place, where the player is in currently
        {
            return MyCurrentPlace;
        }
        public String getMycurrentPlaceName()   //get the current place name, this returns a string
        {
            return MyCurrentPlace.getPlaceName();
        }
        public void setMycurrentPlace(Place place) //set the current place of the player, this should be called everytime the player moves to a different place
        {
            this.MyCurrentPlace = place;
        }


        //inventory Processes 
        public void addtoMyInventory(Item item)
        {
            if (MyCurrentPlace.checkItemIsHere(item))
            {
                inventory.addItem(item);
                MyCurrentPlace.removeItemFromPlace(item);
            }
            else
            {
                Console.WriteLine("There is no such item in this place");
            }

        }

        public void removeFromMyInventory(Item item)
        {
            if (inventory.itemIsInInvenory(item))
            {
                MyCurrentPlace.addItemToPlace(item);
                inventory.removeItem(item);
            }
        }

        public Place _MyOldPlace { get { return MyOldPlace; } set { MyOldPlace = value; } }
        public String printMyInventory() //print every item in the inventory
        {
            return inventory.printInventory();
        }
        public Inventory MyInventory { get{return inventory;} set{inventory=value;} }


    }
}