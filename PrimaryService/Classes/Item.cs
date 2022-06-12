using System;

namespace TextBasedGame
{
    public class Item
    {
        private String itemName; //item name
        private String colour; //colour of the item
        private String shortDescription; //description of the item
        private String specificDescription;
        private bool isPickable; //if the item is pickable; in case it is an asset, it is not
        private bool isOpened;

        public Item(String itemName, String colour = "", String shortDescription = "", String specificDescription="", bool isPickable = true)
        {
            this.itemName = itemName;
            this.shortDescription = shortDescription;
            this.isPickable = isPickable;
            this.colour = colour;
            this.specificDescription= specificDescription;
        }
        public String getItemName()
        {
            return itemName;
        }
        public String getDescription()
        {
            return shortDescription;
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
            this.shortDescription = description;
        }
        public void setColour(String colour)
        {
            this.colour = colour;
        }
        public void setItemName (String itemName){
            this.itemName=itemName;
         }
        public bool hasShortDescription()
        {
            return !(shortDescription.Equals(""));
        }
          public bool hasLongDescription()
        {
            return !(specificDescription.Equals(""));
        }
        public bool getIsOpened(){return isOpened;}
        public void setIsOpened(bool opened){isOpened=opened;}

        public String LongDescription { get{return specificDescription;} set{specificDescription=value;} }
        
        public String use(){
            return "";
        }
        public String use(Item asset){
            return "";
        }
    }
}