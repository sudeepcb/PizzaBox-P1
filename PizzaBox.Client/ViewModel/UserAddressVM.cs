using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Data;
using System.Linq;

namespace PizzaBox.Client.ViewModel
{
    public class UserAddressVM
    {
      private PizzaDBContext _db = new PizzaDBContext();
        public User user { get; set; }
        public List<Address> allAddress { get; set; }

        public List<int> allId { get; set; }
  

        // public UserAddressVM()
        // {
        //   this.allAddress = new List<Address> ();
        //   this.allId = new List<int>();
        // }
    }
}