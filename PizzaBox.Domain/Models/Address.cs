using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Models
{
  public class Address
  {
    [Key]
    public int addressId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }  
    public string State { get; set; }
  
    // internal Address(string s, string c, string st)
    // {
    //   this.Street = s;
    //   this.City = c;
    //   this.State = st;
    // }
  }
}