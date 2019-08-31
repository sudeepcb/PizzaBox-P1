// using System;
// using System.Collections.Generic;
// using PizzaBox.Domain.Recipes;

// namespace PizzaBox.Domain.Models{

//   public class PizzaFactory
//   {
//       public PizzaFactory(string name)
//       {
//         if(name.ToLower() == "custompizza")
//         {
//           System.Console.WriteLine("Custom");
//           var cp = new CustomPizza();
//           List<Toppings> toppings = new List<Toppings>();
//           for(int i = 0; i < 6; i++){
//             System.Console.WriteLine("Enter Topping {0}:", i+1);
//             string input = Console.ReadLine();
//             if(input.ToUpper() == "E"){
//               break;
//             }else{
//               toppings.Add(new Toppings(input));
//             }
//           }
//           var pny = cp.GetComponents(new Size("small"), toppings);
//         }else{
//           System.Console.WriteLine("NY");
//           new NYStyle();
//         }
//       }
//   }
// }