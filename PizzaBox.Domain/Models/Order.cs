using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
        protected int orderId { get; set; }
        public List<APizza> Pizzas { get; set; }
        public decimal totalPrice { get; set; }

        public List<APizza> allPizzas { get{ return Pizzas; }  }

        // public void getEverything()
        // {
        //   foreach (var item in allPizzas)
        //   {
        //      item.getEverything();
        //   }
        // }
        public void addOrder(List<APizza> pizzas){
          Pizzas = new List<APizza>();
          foreach (var item in pizzas)
          {
              Pizzas.Add(item);
          }
        }
        public void checkOrder()
        {
          foreach (var item in Pizzas)
          {
              System.Console.WriteLine(item);
          }
          System.Console.WriteLine("Total Price: {0}", totalPrice);
        }

        public Order(List<APizza> pizzas)
        {
          totalPrice = pizzas.Count * 10M;
          addOrder(pizzas);
        }
    }
}