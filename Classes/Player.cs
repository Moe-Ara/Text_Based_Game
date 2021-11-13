using System;
using System.Collections.Generic;
using TextBasedGame;
namespace TextBasedGame
{
    class Player
    {
        private String name;
        private String sex;
        private String Description;
        private Place MyCurrentPlace;
        protected HashSet<Item> inventory;

        public Player(String name, String sex, String Description, Place MyCurrentPlace)
        {
            this.name = name;
            this.sex = sex;
            this.Description = Description;
            this.MyCurrentPlace = MyCurrentPlace;
            this.inventory = new HashSet<Item>();
            this.inventory.Add(new Item("Pocket Knife", "", "It is small pocket knife with a wooden grip" +
            ".\nThe blade seems a bit rusty and dull but it is sharp enough to cut through some thin materials", true));
        }

        public String getName() { return name; }
        public String getSex() { return sex; }

        public String getDescription() { return Description; }
        public Place getMycurrentPlace()
        {
            return MyCurrentPlace;
        }
        public String getMycurrentPlaceName()
        {
            return MyCurrentPlace.getPlaceName();
        }
        public void setMycurrentPlace(Place place)
        {
            this.MyCurrentPlace = place;
        }
        public String printInventory()
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
        public void addToInventory(Item item)
        {
            inventory.Add(item);
            MyCurrentPlace.removeItemFromPlace(item);
        }
        public void dropItemFromInventory(Item item)
        {
            inventory.Remove(item);
            MyCurrentPlace.addItemToPlace(item);
        }



    }
}