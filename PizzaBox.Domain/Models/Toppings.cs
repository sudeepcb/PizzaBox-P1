
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Toppings
  {
    [Key]
    public int toppingsId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    // internal Toppings(string name) : base(name){}
  }
}

