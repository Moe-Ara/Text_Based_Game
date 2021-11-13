using System;
using item.cs;
using System.Collections.Generic;
class Place {
    private String CurrentPlace;
    private String PlaceToNorth;
    private String PlaceToSouth;
    private String PlaceToEast;
    private String PlaceToWest;
    private String Description;
    protected HashSet<item> itemsInPlace;
    public Place (String CurrentPlace, String PlaceToNorth, String PlaceToSouth,String PlaceToEast,String PlaceToWest){
        this.CurrentPlace= CurrentPlace;
        this.PlaceToNorth= PlaceToNorth;
        this.PlaceToSouth= PlaceToSouth;
        this.PlaceToEast= PlaceToEast;
        this .PlaceToWest= PlaceToWest;
    }

    String getCurrentPlace(){
        return CurrentPlace;
    }
    String getPlaceToNorth(){
        return PlaceToNorth;
    }
    String getPlaceToSouth(){
        return PlaceToSouth;
    }
    String getPlaceToEast(){
        return PlaceToEast;
    }
    String getPlaceToWest(){
        return PlaceToWest;
    }
    String getDescription(){
        return Description;
    }
    void setDescription(String desc){
        this.Description=desc;
    }
    bool hasNorth(){
        return (getPlaceToNorth!="");
    }
    bool hasSouth(){
        return(getPlaceToSouth!="");
    }
    bool hasEast(){
        return(getPlaceToEast!="");
    }
    bool hasWest(){
        return(getPlaceToWest!="");
    }
    //adds items to place
    void addItemToPlace(item item){
        try{
        itemsInPlace.Add(item);}
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
    //checks if an item exists in current place
    void checkItemIsHere(item item){
        return itemsInPlace.Contains(item);
    }
    //removes an item form current place
    void removeItemFromPlace(item item){
        if (checkItemIsHere(item)){
            itemsInPlace.Remove(item);
        }else{
            Console.WriteLine("There is no such item in current place");
        }
    }



}