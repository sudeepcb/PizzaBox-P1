using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class User
    {
       public string firstName { get; set; }
       protected int userId { get; set; }
        public string lastName { get; set; } 
       public List<Order> Orders{ get; set;}
       public Address recentAddress { get; set; }

       public List<Address> allAddress { get; set; }

       public List<Address> GetLocations()
       {
         List<Address> addresses = new List<Address>();
         addresses.Add(new Address("1234 Wierdo Street", "Dallas", "Texas"));
         addresses.Add(new Address("12345 Wierdo Street", "Dallas", "Texas"));
         addresses.Add(new Address("12346 Wierdo Street", "Dallas", "Texas"));
         addresses.Add(new Address("12347 Wierdo Street", "Dallas", "Texas"));
         addresses.Add(new Address("12348 Wierdo Street", "Dallas", "Texas"));

         return addresses;
       }
        public Address pickAddress()
        {
          var x = GetLocations();
          int i = 0;
          foreach (var item in x)
          {
              System.Console.WriteLine("{0}:{1}, {2}, {3}", i, item.Street, item.City, item.State);
              i++;
          }
          System.Console.WriteLine("Which location do you want?");
          int addressValue = 0;
          while(addressValue == 0)
          {
          addressValue = Convert.ToInt32(System.Console.ReadLine());
          }
          return x[addressValue];
        }

        public User(string fname, string lname)
        {
          this.firstName = fname;
          this.lastName = lname;
          this.recentAddress = pickAddress();
        }
    }
}