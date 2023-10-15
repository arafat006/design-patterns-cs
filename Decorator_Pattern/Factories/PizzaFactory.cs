using Decorator_Pattern.Products;

namespace Decorator_Pattern.Factories
{
  public class PizzaFactory : IPizza
  {
    private readonly IPizza _pizza;

    public PizzaFactory(IPizza pizza)
    {
      _pizza = pizza;
    }

    public virtual void Prepare()
    {
      _pizza.Prepare();
    }
  }
}
