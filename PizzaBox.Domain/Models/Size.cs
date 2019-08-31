using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Size : AComponent
  {
    protected int sizeId { get; set; }
    public Size(string name):base(name){}
  }
}