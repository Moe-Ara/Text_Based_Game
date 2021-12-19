using System;
using System.Collections.Generic;

namespace TextBasedGame{
    public class ContianerItem : Item{
        private String _Contentes;

        public ContianerItem(String ItemName, String shortDescription,String LongDescription="", String Contents="", bool Pickable=true): base(ItemName,"",shortDescription,LongDescription,Pickable){
            this._Contentes=Contents;
        }

        public String  Contents { get{return _Contentes;} set{_Contentes=value;} }
    }
    public class Box : ContianerItem{
        private HashSet<Item> _Contents;
        public Box(String ItemName, String Description,String LongDescription="", bool Pickable =false):base(ItemName, Description,LongDescription," ", Pickable){
            _Contents = new HashSet<Item>();
        }

        public HashSet<Item> getContents {
         get{

             return _Contents;
         }
         set{_Contents =value;} 
         }
        public String PrintContents (){
             String contents= " ";
             foreach (Item x in _Contents){
                 contents += x.getItemName() + "; ";
                contents= contents.Remove(contents.Length-1);
             }
             return contents;

             }
        public void addContents (Item item){
            if (item!=null)
                _Contents.Add(item);
        }
        public void removeContents(Item item){
            _Contents.Remove(item);
        }
        public void pickItem(Item item){
            if (item.getIsPickable())
                removeContents(item);
        }

        public Boolean contains(Item item){
            return _Contents.Contains(item);
        } 
    }
}