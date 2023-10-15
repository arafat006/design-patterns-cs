using Decorator_Pattern.Factories;
using Decorator_Pattern.Products;

namespace Decorator_Pattern.Decorators
{
    public class PepperoniPizza : PizzaFactory
  {
    public PepperoniPizza(IPizza pizza) : base(pizza)
    {
    }

    public override void Prepare()
    {
      base.Prepare();
      Console.WriteLine("Adding Pepperoni Topping");
    }
  }
}
