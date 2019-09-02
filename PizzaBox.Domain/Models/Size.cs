using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Size
  {
    [Key]
    public int sizeId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    // internal Size(string name):base(name){}
  }
}