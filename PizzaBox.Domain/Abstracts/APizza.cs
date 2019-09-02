using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class APizza
    {
        public int Id { get; set; }
        public Crust crust { get; set; }
        public Size size { get; set; }

        public List<Toppings> Toppings { get; set; } 
        protected List<AComponent> _components;

        public List<AComponent> Components { get{ return _components; }  }
        public abstract List<AComponent> GetComponents(Crust c, Size s, List<Toppings> t);

        public abstract void getEverything();

        public abstract override string ToString();
    }
}