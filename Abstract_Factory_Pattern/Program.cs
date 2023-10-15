using Abstract_Factory_Pattern.Factories;
using Abstract_Factory_Pattern.Products.Burger;
using Abstract_Factory_Pattern.Products.Pizza;

Waiter waiter = new Waiter("Veg");

// Creating provider using preference
var vegPizza = waiter.GetPizza();
var vegBurger = waiter.GetBurger();

Console.WriteLine(vegPizza.Eat());
Console.WriteLine(vegBurger.Eat());


// Provider class creates factory depending on conditions and return object
class Waiter
{
  private IChef foodFactory;

  public Waiter(string preference)
  {
    if (preference == "Veg")
      foodFactory = new VegChef();
    else
      foodFactory = new NonVegChef();
  }

  public IPizza GetPizza() {
    return foodFactory.PreparePizza();
  }

  public IBurger GetBurger()
  {
    return foodFactory.PrepareBurger();
  }
}

// Saves preference once and serving same categorized objects and the objects are compatible in between them
// Supports Single Responsibility Princle and Open-close principle
