using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class CustomPizza : APizza 
    {
      //  public Crust crust { get; set; }
      //  public Size size { get; set; }

      //  public List<Toppings> Toppings { get; set; }

        
       public override List<AComponent> GetComponents(Size s, List<Toppings> t)
      {
        _components = new List<AComponent>();
        string inputCrust = null;
        System.Console.WriteLine("Since you are creating a custom pizza enter your crust: ");
        inputCrust = System.Console.ReadLine();
        _components.Add(new Crust(inputCrust));
        _components.Add(s);
        _components.AddRange(t);
        foreach (var item in _components)
        {
            System.Console.WriteLine(item.Name);
        }

        return Components;
      }

      public override void getEverything()
      {
        System.Console.Write("{0} ", ToString());
        foreach(var item in Components)
        {
          System.Console.Write("{0} ",item.Name);
          
        }
        System.Console.WriteLine();
      }
      

      public CustomPizza(string size)
      {
          Size pizzaSize = new Size(size);
          List<Toppings> toppings = new List<Toppings>();
          for(int i = 0; i < 6; i++){
            System.Console.WriteLine("Enter Topping {0}:", i+1);
            string input = Console.ReadLine();
            if(input.ToUpper() == "E"){
              break;
            }else{
              toppings.Add(new Toppings(input));
            }
          }
          GetComponents(pizzaSize, toppings);
      }

      public override string ToString()
      {
        return $"Custom Pizza";
      }

  
    }
}