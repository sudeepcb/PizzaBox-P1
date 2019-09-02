using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models
{
  public class CustomPizza 
    {
      [Key]
      public int CustomPizzaId { get; set; }
       public Crust crust { get; set; }
       public Size size { get; set; }
      public List<Toppings> Toppings { get; set; }
      [NotMapped]
      protected List<string> _components;
        
      //  public List<string> GetComponents(Crust c, Size s, List<Toppings> t)
      // {
      //   _components = new List<string>();
      //   _components.Add(c.Name);
      //   _components.Add(s.Name);
      //   foreach (var item in t)
      //   {
      //       _components.Add(item.Name);
      //   }
      //   return _components;
      // }

      // public void getEverything()
      // {
      //   System.Console.Write("{0} ", ToString());
      //   foreach(var item in _components)
      //   {
      //     System.Console.Write("{0} ",item);
          
      //   }
      //   System.Console.WriteLine();
      // }
      

      // // internal CustomPizza(Crust c, Size s, List<Toppings> toppings)
      // // {
      // //     GetComponents(c,s, toppings);
      // // }

      // public override string ToString()
      // {
      //   return $"Custom Pizza";
      // }

  
    }
}