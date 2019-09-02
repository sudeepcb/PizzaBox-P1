using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
      [Key]
        public int orderId { get; set; }
        public List<CustomPizza> CustomPizza { get; set; }
        public decimal totalPrice { get; set; }

        // public List<APizza> allPizzas { get{ return Pizzas; }  }

        // public void getEverything()
        // {
        //   foreach (var item in allPizzas)
        //   {
        //      item.getEverything();
        //   }
        // }
        // public void addOrder(List<CustomPizza> pizzas){
        //   Pizzas = new List<CustomPizza>();
        //   foreach (var item in pizzas)
        //   {
        //       Pizzas.Add(item);
        //   }
        // }
        // public void checkOrder()
        // {
        //   foreach (var item in Pizzas)
        //   {
        //       System.Console.WriteLine(item);
        //   }
        //   System.Console.WriteLine("Total Price: {0}", totalPrice);
        // }

        // internal Order(List<APizza> pizzas)
        // {
        //   totalPrice = pizzas.Count * 10M;
        //   addOrder(pizzas);
        // }
    }
}