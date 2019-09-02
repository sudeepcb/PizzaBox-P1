using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Models
{
    public class User
    {
      // private PizzaDBContext _db = new PizzaDBContext();
      [Key]
      public int userId { get; set; }

      [Required (ErrorMessage="Must Enter a Username to continue")]
       public string userName { get; set; } 
       public List<Order> Order{ get; set;}

       [Required (ErrorMessage="Must select a location to order a pizza")]
       public Address Address { get; set; }

      //  public List<Address> GetLocations()
      //  {
      //    List<Address> addresses = new List<Address>();
      //   //  addresses.Add(new Address("1234 Wierdo Street", "Dallas", "Texas"));
      //   //  addresses.Add(new Address("12345 Wierdo Street", "Dallas", "Texas"));
      //   //  addresses.Add(new Address("12346 Wierdo Street", "Dallas", "Texas"));
      //   //  addresses.Add(new Address("12347 Wierdo Street", "Dallas", "Texas"));
      //   //  addresses.Add(new Address("12348 Wierdo Street", "Dallas", "Texas"));

      //    return addresses;
      //  }
      //   public void pickAddress()
      //   {
      //     var x = GetLocations();
      //     int i = 1;
      //     foreach (var item in x)
      //     {
      //         System.Console.WriteLine("{0}:{1}, {2}, {3}", i, item.Street, item.City, item.State);
      //         i++;
      //     }
      //     System.Console.WriteLine("Which location do you want?");
      //     int addressValue = 0;
      //     while(addressValue == 0)
      //     {
      //     addressValue = Convert.ToInt32(System.Console.ReadLine());
      //     }
      //     this.recentAddress = x[addressValue - 1];
      //   }

      //   public void addUser(User user)
      //   {

      //   }

        // public User()
        // {
        //   this.recentAddress = new Address();
        // }
    }
}