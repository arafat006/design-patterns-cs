using Factory_Pattern.Factories;
using Factory_Pattern.Products;

Waiter waiter = new Waiter();

var vegPizza = waiter.GetPizza("Veg");
Console.WriteLine(vegPizza.Eat());

var nonVegPizza = waiter.GetPizza("Non-Veg");
Console.WriteLine(nonVegPizza.Eat());


//Provider class creates factory depending on conditions and return object
class Waiter
{
  public IPizza GetPizza(string type)
  {
    IPizzaChef chef;
    switch (type)
    {
      case "Veg":
        chef = new VegPizzaChef();
        break;
      default:
        chef = new NonVegPizzaChef();
        break;
    }

    return chef.PreparePizza();
  }
}

// Can be usefull when multiple API is used for the same work
// Real life Example: Many Cricket APIs are availble but which to use can be choose by this pattern easily