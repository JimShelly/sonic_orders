using System.Collections.Generic;

namespace Exam{

   public class Item{
      private readonly int _key;
      private readonly string _name;
      private readonly float _price;

      public Item(int key, string name, float price){
         this._key = key;
         this._name = name;
         this._price = price;
      }         

      public int GetKey(){
         return _key;
      }

      public string GetName(){
         return _name;
      }

      public float GetPrice(){
         return _price;
      }      
   }
}