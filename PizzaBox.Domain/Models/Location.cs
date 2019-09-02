using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models
{
    public class Location
    {
      [Key]
      public int locationId {get; set;}
      public Address Address { get; set; }
      // protected Dictionary<string, int> Inventory { get; set;}
      public List<OrderHistory> OrderHistory { get; set; }

      // public void MakeOrder(User user, Order order)
      // {
      //   System.Console.WriteLine(Address.Street);
      //   var oh = new OrderHistory();
      //   oh.user = user;
      //   oh.order = order;
      //   History = new List<OrderHistory>();
      //   History.Add(oh);
      //   foreach (var item in History)
      //   {
      //       item.order.checkOrder();
      //   }
      // }
      
      // internal Location(Address orderAddress)
      // {
      //   this.Address = orderAddress;
      // }
    }
}