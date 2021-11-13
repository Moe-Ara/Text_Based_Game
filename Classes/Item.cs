using System;
class item{
    private String itemName;
    private String colour;
    private String description;
    private bool isPickable;

    public item(String itemName,String colour="", String description ="", bool isPickable=false){
        this.itemName=itemName;
        this.description= description;
        this.isPickable=isPickable;
        this.colour=colour;
    }
    String getItemName(){
        return itemName;
    }
    String getDescription(){
        return description;
    }
    String getColour(){
        return colour;
    }
    bool getIsPickable(){
        return isPickable;
    }
    String setDescription(String description){
        this.description=description;
    }
    String setColour(String colour){
        this.colour =colour;
    }
    bool hasDescription(){
        return (getDescription!="");
    }
}