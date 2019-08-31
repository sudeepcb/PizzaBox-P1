using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class OrderHistory
    {
        public User user { get; set; }


        public Order allOrders { get; set; }


        public OrderHistory(User u, Order o)
        {
          this.user = u;
          this.allOrders = o;
        }
    }
}