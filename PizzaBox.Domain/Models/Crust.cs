using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Crust : AComponent
  {
   protected int crustId { get; set; }
   public Crust(string name) : base(name){}

    
  }
}