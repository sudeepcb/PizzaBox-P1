namespace PizzaBox.Domain.Abstracts
{
  public abstract class AComponent
  {
      public string Name { get; set; }
      public decimal Price { get; set; }

      public AComponent(string name)
      {
        this.Name = name;
      }
  }
}
