using Abstract_Factory_Pattern.Products.Burger;
using Abstract_Factory_Pattern.Products.Pizza;

namespace Abstract_Factory_Pattern.Factories
{
  public interface IChef
  {
    IPizza PreparePizza();
    IBurger PrepareBurger();
  }
}
