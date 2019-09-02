using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Crust 
  {
    [Key]
   public int crustId { get; set; }
   public string Name { get; set; }
   public decimal Price { get; set; }

  //  internal Crust(string name) : base(name){}

    
  }
}