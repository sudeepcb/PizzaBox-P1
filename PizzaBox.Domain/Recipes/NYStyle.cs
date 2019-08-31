using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
    public class NYStyle : APizza
    {
   

    public override List<AComponent> GetComponents(Size s, List<Toppings> t)
      {
        _components = new List<AComponent>();
        _components.Add(new Crust("NewYork"));
        _components.Add(s);
        _components.AddRange(t);

        System.Console.WriteLine(s.Name);
        foreach (var item in _components)
        {
            System.Console.WriteLine(item.Name);
        }

        return Components;
      }

      public override void getEverything()
      {}

    public NYStyle()
    {
      
    }

    }
}