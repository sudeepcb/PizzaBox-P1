
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Toppings : AComponent
  {
    protected int toppingsId { get; set; }
    public Toppings(string name) : base(name){}
  }
}

