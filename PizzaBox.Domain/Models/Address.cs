namespace PizzaBox.Domain.Models
{
  public class Address
  {
    public string Street { get; set; }
    public string City { get; set; }  
    public string State { get; set; }
  
    public Address(string s, string c, string st)
    {
      this.Street = s;
      this.City = c;
      this.State = st;
    }
  }
}