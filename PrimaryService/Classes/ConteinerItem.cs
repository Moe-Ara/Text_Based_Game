using System;
using System.Collections.Generic;

namespace TextBasedGame{
    public class ContianerItem : Item{
        private String _Contentes;

        public ContianerItem(String ItemName, String Description, String Contents, bool Pickable=true): base(ItemName,"",Description,Pickable){
            this._Contentes=Contentes;
        }

        public String Contentes { get{return _Contentes;} set{_Contentes=value;} }
    }
    public class Box : ContianerItem{
        private HashSet<Item> _Contents;
        public Box(String ItemName, String Description, bool Pickable =false):base(ItemName, Description," ", Pickable){

        }

        public HashSet<Item> Contents {
         get{
             return Contents;
         }
         set{Contents =value;} 
         }
        public String PrintContents (){
             String contents= " ";
             foreach (Item x in Contents){
                 contents += x.getItemName() + "; ";
                 contents.Remove(contents.Length-1);
             }
             return contents;

             }
        public void addContents (Item item){
            Contents.Add(item);
        }
    }
}