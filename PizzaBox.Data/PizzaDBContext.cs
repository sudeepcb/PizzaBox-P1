using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;



namespace PizzaBox.Data
{
    public class PizzaDBContext : DbContext
    {
        public DbSet<CustomPizza> CustomPizzas {get; set;}
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Toppings> Toppings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder sqlbuilder)
        {
          sqlbuilder.UseSqlServer("server=localhost;initial catalog=PizzaDB;user id=sa;password=Password1234;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<User>().HasIndex(u => u.userName).IsUnique();
        builder.Entity<Address>().HasIndex(a => a.Street).IsUnique();
        builder.Entity<Crust>().HasIndex(c => c.Name).IsUnique();
        builder.Entity<Size>().HasIndex(s => s.Name).IsUnique();
        builder.Entity<Toppings>().HasIndex(t => t.Name).IsUnique();
        
        
        }
    

    
    }
}