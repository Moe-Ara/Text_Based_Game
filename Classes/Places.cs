using System;
using System.Collections.Generic;
using TextBasedGame;
namespace TextBasedGame{
class Place {
    private String PlaceName;
    private String PlaceToNorth;
    private String PlaceToSouth;
    private String PlaceToEast;
    private String PlaceToWest;
    private String Description;
    protected HashSet<Item> itemsInPlace;
    public Place (String PlaceName, String PlaceToNorth, String PlaceToSouth,String PlaceToEast,String PlaceToWest){
        this.PlaceName= PlaceName;
        this.PlaceToNorth= PlaceToNorth;
        this.PlaceToSouth= PlaceToSouth;
        this.PlaceToEast= PlaceToEast;
        this .PlaceToWest= PlaceToWest;
        this.itemsInPlace= new HashSet<Item>();
    }

   public String getPlaceName(){
        return PlaceName;
    }
   public String getPlaceToNorth(){
        return PlaceToNorth;
    }
    public String getPlaceToSouth(){
        return PlaceToSouth;
    }
    public String getPlaceToEast(){
        return PlaceToEast;
    }
    public String getPlaceToWest(){
        return PlaceToWest;
    }
    public String getDescription(){
        return Description;
    }
    public void setDescription(String desc){
        this.Description=desc;
    }
   public bool hasNorth(){
        return !(PlaceToNorth.Equals(""));
    }
   public bool hasSouth(){
        return !(PlaceToSouth.Equals(""));
    }
   public bool hasEast(){
        return !(PlaceToEast.Equals(""));
    }
   public bool hasWest(){
        return !(PlaceToWest.Equals(""));
    }
    //adds items to place
   public void addItemToPlace(Item item){
        try{
        itemsInPlace.Add(item);}
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
    //checks if an item exists in current place
   public bool checkItemIsHere(Item item){
        return itemsInPlace.Contains(item);
    }
    //removes an item form current place
   public void removeItemFromPlace(Item item){
        if (checkItemIsHere(item)){
            itemsInPlace.Remove(item);
        }else{
            Console.WriteLine("There is no such item in current place");
        }
    }



}}