using Decorator_Pattern.Factories;
using Decorator_Pattern.Products;

namespace Decorator_Pattern.Decorators
{
    public class CapsicumPizza : PizzaFactory
  {
    public CapsicumPizza(IPizza pizza) : base(pizza)
    {
    }

    public override void Prepare()
    {
      base.Prepare();
      Console.WriteLine("Adding Capsicum Topping");
    }
  }
}
