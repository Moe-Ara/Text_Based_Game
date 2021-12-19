using System;
using System.Collections.Generic;

namespace TextBasedGame
{
    public class Inventory
    {
        private Place plyersPlace;
        protected HashSet<Item> inventory; //player's inventory
        public Inventory()
        {
            inventory = new HashSet<Item>();
            this.inventory.Add(new Item("Pocket Knife", "", "It is small pocket knife with a wooden grip" +
            ".\nThe blade seems a bit rusty and dull but it is sharp enough to cut through some thin materials",null, true));
        }
        public String printInventory() //print every item in the inventory
        {
            String items = "";
            foreach (Item x in inventory)
            {
                items += x.getItemName() + "; ";
                //removes the last semicolon
                items=items.Remove(items.Length - 1);
            }
            return items;
        }
        public void addItem(Item item) //add item to inventory
        {
            inventory.Add(item);//pick it up
        }
        public void removeItem(Item item) //remove item from inventory
        {
            inventory.Remove(item); //drop it
        }

        public bool itemIsInInvenory(Item item)
        {
            return inventory.Contains(item);
        }
    }
}
