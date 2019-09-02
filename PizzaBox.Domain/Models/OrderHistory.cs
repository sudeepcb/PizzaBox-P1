using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class OrderHistory
    {
        [Key]
        public int orderHistoryId { get; set; }
        public User user { get; set; }


        public Order order { get; set; }


        // internal OrderHistory(User u, Order o)
        // {
        //   this.user = u;
        //   this.allOrders = o;
        // }
    }
}