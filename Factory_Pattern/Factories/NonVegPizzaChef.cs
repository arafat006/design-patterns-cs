using Factory_Pattern.Products;

namespace Factory_Pattern.Factories
{
  //Factory of non veg pizza
  public class NonVegPizzaChef : IPizzaChef
  {
    public IPizza PreparePizza()
    {
      return new NonVegPizza();
    }
  }
}
