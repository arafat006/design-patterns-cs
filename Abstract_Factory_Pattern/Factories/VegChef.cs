using Abstract_Factory_Pattern.Products.Burger;
using Abstract_Factory_Pattern.Products.Pizza;

namespace Abstract_Factory_Pattern.Factories
{
  //Factory of veg product
  public class VegChef : IChef
  {
    public IPizza PreparePizza()
    {
      return new VegPizza();
    }

    public IBurger PrepareBurger()
    {
      return new VegBurger();
    }
  }
}
