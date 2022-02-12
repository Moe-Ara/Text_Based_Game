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
        private Place PlayersOldPlace; //to be able to go back
        private Place PlayersCurrentPlace; //Player's current place
        private Inventory inventory; //player's inventory

        public Player(String name, String sex, String Description, Place MyCurrentPlace, Inventory inventory)
        {
            this.name = name;
            this.sex = sex;
            this.Description = Description;
            this.PlayersCurrentPlace = MyCurrentPlace;
            this.inventory = inventory;
        }
        public String getName() { return name; } //getter for Player Name
        public String getSex() { return sex; }     //getter for Player's sex

        public String getDescription() { return Description; }  //getter for player's description
        public Place getPlayerscurrentPlace()    //getter to get the current place, where the player is in currently
        {
            return PlayersCurrentPlace;
        }
        public String getPlayerscurrentPlaceName()   //get the current place name, this returns a string
        {
            return PlayersCurrentPlace.getPlaceName();
        }
        public void setPlayerscurrentPlace(Place place) //set the current place of the player, this should be called everytime the player moves to a different place
        {
            this.PlayersCurrentPlace = place;
        }


        //inventory Processes 
        public void addtoInventory(Item item)
        {
            if (PlayersCurrentPlace.checkItemIsHere(item))
            {
                inventory.addItem(item);
                PlayersCurrentPlace.removeItemFromPlace(item);
            }
            else
            {
                Console.WriteLine("There is no such item in this place");
            }

        }

        public void removeFromInventory(Item item)
        {
            if (inventory.itemIsInInvenory(item))
            {
                PlayersCurrentPlace.addItemToPlace(item);
                inventory.removeItem(item);
            }
        }

        public Place _PlayersOldPlace { get { return PlayersOldPlace; } set { PlayersOldPlace = value; } }
        public String printMyInventory() //print every item in the inventory
        {
            return inventory.printInventory();
        }
        public Inventory PlayersInventory { get{return inventory;} set{inventory=value;} }


    }
}