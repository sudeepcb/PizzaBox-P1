using System;
using PizzaBox.Domain.Recipes;
using PizzaBox.Domain.Models;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
          //   //MakeCustomStyle();
          // string input = null;
          // var pizzas = new List<APizza>();    
          // int i = 0;
          // Boolean controlSwitch = true;
          // System.Console.WriteLine("What would you like to do [1]Order Custom Pizza [2]Order NYStyle Pizza [3]Exit");
          // input = Console.ReadLine();        
          // while(controlSwitch)
          // {    
          //   if(i > 0)
          //   {
          //     System.Console.WriteLine("What would you like to do next [1]Order Custom Pizza [2] Order NYStyle Pizza [3] Exit");
          //     input = Console.ReadLine();    
          //   }
          //   switch (input)
          //   {
          //       case "1": System.Console.WriteLine("Ordering Custom Pizza");
          //                 System.Console.WriteLine("What Size?");
          //                 string size = Console.ReadLine();
          //                 var cp = new CustomPizza(size);
          //                 pizzas.Add(cp);
          //                 i++;
          //                 continue;
          //       case "2": System.Console.WriteLine("Ordering NyStyle");
          //                 var ny = new CustomPizza("custompizza");
          //                 pizzas.Add(ny);
          //                 i++;
          //                 continue;
          //       case "3": System.Console.WriteLine("Here is your order so far");
          //                 foreach (var item in pizzas)
          //                 {
          //                     item.getEverything();
          //                 }
          //                 i++;
          //                 continue;
          //       case "4": 
          //                 var allPizzas = new Order(pizzas);
          //                 System.Console.WriteLine(allPizzas.totalPrice);
          //                 controlSwitch = false;
          //                 break;
                
          //       default: 
          //                 System.Console.WriteLine("Wrong Input Bro!");
          //                 continue;
                            
          //   }
          // }
          // pizzas.Add(new CustomPizza("medium"));
          // pizzas.Add(new CustomPizza("large"));
          var myUser = new User("sudeep", "baniya");
          var myLocation = new Location(myUser.recentAddress);
          // var myAddress = myUser.pickAddress();
          //System.Console.WriteLine("Added Address: {0}", myUser.recentAddress.City);
          var pizzas = new List<APizza>();
          pizzas.Add(new CustomPizza("small"));
          pizzas.Add(new CustomPizza("large"));
          var totalOrder = new Order(pizzas);
          myLocation.MakeOrder(myUser, totalOrder);

          
        }
        // static void MakeNYStyle()
        // {
        //   System.Console.WriteLine("Entered NyStyle");
        //   List<Toppings> toppings = new List<Toppings>();
        //   for(int i = 0; i < 6; i++){
        //     System.Console.WriteLine("Asking input {0}:", i+1);
        //     string input = Console.ReadLine();
        //     if(input.ToUpper() == "E"){
        //       break;
        //     }else{
        //       toppings.Add(new Toppings(input));
        //     }
        //   }
        //   var ny = new NYStyle();
        //   var pny = ny.GetComponents(new Size("small"), toppings);
        //   var order = new Order();
        //   //var ny1 = new CustomPizza();
        //   //ny1.GetComponents(new Size("small"), toppings);
        //   //var order1 = new Order();
        //   //order1.addOrder(ny1);
        //   order.addOrder(ny);
          
        // }

        // static void MakeCustomStyle()
        // {
        //   System.Console.WriteLine("Making Custom Pizza");
        //   List<Toppings> toppings = new List<Toppings>();
        //   for(int i = 0; i < 6; i++){
        //     System.Console.WriteLine("Asking input {0}:", i+1);
        //     string input = Console.ReadLine();
        //     if(input.ToUpper() == "E"){
        //       break;
        //     }else{
        //       toppings.Add(new Toppings(input));
        //     }
        //   }
        //   var ny1 = new CustomPizza();
        //   ny1.GetComponents(new Size("small"), toppings);
        //   var order1 = new Order();
        //   order1.addOrder(ny1);
          
        // }
        
    }
}
