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
        private Place MyCurrentPlace; //Player's current place
        protected HashSet<Item> inventory; //player's inventory

        public Player(String name, String sex, String Description, Place MyCurrentPlace)
        {
            this.name = name;
            this.sex = sex;
            this.Description = Description;
            this.MyCurrentPlace = MyCurrentPlace;
            this.inventory = new HashSet<Item>();
            //we give every player a pocket knife at the start
            this.inventory.Add(new Item("Pocket Knife", "", "It is small pocket knife with a wooden grip" +
            ".\nThe blade seems a bit rusty and dull but it is sharp enough to cut through some thin materials", true));
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
        public String printInventory() //print every item in the inventory
        {
            String items = "";
            foreach (Item x in inventory)
            {
                items += x.getItemName() + "; ";
                //removes the last semicolon
                items.Remove(items.Length - 1);
            }
            return items;
        }
        public void addToInventory(Item item) //add item to inventory
        {
            inventory.Add(item);//pick it up
            MyCurrentPlace.removeItemFromPlace(item); //remove it from current place, because we have picken it up
        }
        public void dropItemFromInventory(Item item) //remove item from inventory
        {
            inventory.Remove(item); //drop it
            MyCurrentPlace.addItemToPlace(item); //add to the current place because we have thrown it away, 
                                                //the player can now pick it up again but from where they droped it 
        }

        public bool itemIsInInvenory(Item item){
            return inventory.Contains(item);
        }


    }
}