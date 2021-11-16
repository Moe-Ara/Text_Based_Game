using System;
namespace TextBasedGame
{

    /*
    * This class inherits everything from class item
    * It has two extra attributes, AssetName and AssetDescription
    * When a new Asset is created, this class calls the constructor from  item and creates a new Item with AssetName and AssetDescription
    */
    class Asset : Item{
        private String AssetName;
        private String AssetDescription;
        public Asset(String assetName, String assetDescription): base(assetName, "", assetDescription,false){
            this.AssetName= assetName;
            this.AssetDescription= assetDescription;
        }

        public String getAssetName { get{return AssetName;} set{this.AssetName=value; base.setItemName(AssetName);} }
        public String getAssetDescription { get{return AssetDescription;} set{AssetDescription=value; base.setDescription(AssetDescription);} }

    }
    
}