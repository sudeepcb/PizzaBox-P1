using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Domain.Models
{
    public class Location
    {
      protected int locationId {get; set;}
      public Address Address { get; set; }
      // protected Dictionary<string, int> Inventory { get; set;}
      protected List<OrderHistory> History { get; set; }

      public void MakeOrder(User user, Order order)
      {
        System.Console.WriteLine(Address.Street);
        History = new List<OrderHistory>();
        History.Add(new OrderHistory(user, order));
        foreach (var item in History)
        {
            item.allOrders.checkOrder();
        }
      }
      
      public Location(Address orderAddress)
      {
        this.Address = orderAddress;
      }
    }
}