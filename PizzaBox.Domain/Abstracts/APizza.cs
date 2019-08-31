using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class APizza
    {
        protected int pizzaId { get; set; }

        public List<Toppings> Toppings { get; set; } 
        protected List<AComponent> _components;

        public List<AComponent> Components { get{ return _components; }  }
        public abstract List<AComponent> GetComponents(Size s, List<Toppings> t);

        public abstract void getEverything();
    }
}