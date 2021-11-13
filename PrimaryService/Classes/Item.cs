using System;
using TextBasedGame;

namespace TextBasedGame
{
    public class Item
    {
        private String itemName; //item name
        private String colour; //colour of the item
        private String description; //description of the item
        private bool isPickable; //if the item is pickable; in case it is an asset, it is not

        public Item(String itemName, String colour = "", String description = "", bool isPickable = false)
        {
            this.itemName = itemName;
            this.description = description;
            this.isPickable = isPickable;
            this.colour = colour;
        }
        public String getItemName()
        {
            return itemName;
        }
        public String getDescription()
        {
            return description;
        }
        public String getColour()
        {
            return colour;
        }
        public bool getIsPickable()
        {
            return isPickable;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public void setColour(String colour)
        {
            this.colour = colour;
        }
        public bool hasDescription()
        {
            return !(description.Equals(""));
        }
    }
}