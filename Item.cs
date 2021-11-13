using System;
class item{
    private String itemName;
    private String description;

    public item(String itemName, String description =""){
        this.itemName=itemName;
        this.description= description;
    }
    String getItemName(){
        return itemName;
    }
    String getDescription(){
        return description;
    }
    String setDescription(String description){
        this.description=description;
    }
    bool hasDescription(){
        return (getDescription!="");
    }
}