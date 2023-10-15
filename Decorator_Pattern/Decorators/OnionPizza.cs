using Decorator_Pattern.Factories;
using Decorator_Pattern.Products;

namespace Decorator_Pattern.Decorators
{
    public class OnionPizza : PizzaFactory
  {
    public OnionPizza(IPizza pizza) : base(pizza)
    {
    }

    public override void Prepare()
    {
      base.Prepare();
      Console.WriteLine("Adding Onion Topping");
    }
  }
}
