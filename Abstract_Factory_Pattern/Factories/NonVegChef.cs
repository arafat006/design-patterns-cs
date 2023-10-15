using Abstract_Factory_Pattern.Products.Burger;
using Abstract_Factory_Pattern.Products.Pizza;

namespace Abstract_Factory_Pattern.Factories
{
  //Factory of non veg product
  public class NonVegChef : IChef
  {
    public IPizza PreparePizza()
    {
      return new NonVegPizza();
    }

    public IBurger PrepareBurger()
    {
      return new NonVegBurger();
    }
  }
}
