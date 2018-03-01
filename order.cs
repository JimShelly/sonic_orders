using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Exam{
   [Serializable]
   class Order : ISerializable {
      private readonly OrderItem[] _orderItems;

      public void GetObjectData(SerializationInfo info, StreamingContext context){

      }
      
      public Order(OrderItem[] orderItems){
         this._orderItems = orderItems;
      }

      public float GetOrderTotal(float taxRate){
         return 0; //TODO:Implment this method
      }

      public ICollection<Item> GetItems(){
         return null; //TODO:Implement this method
      }
   }
}