using Factory_Pattern.Products;

namespace Factory_Pattern.Factories
{
  //Factory of veg pizza
  public class VegPizzaChef : IPizzaChef
  {
    public IPizza PreparePizza()
    {
      return new VegPizza();
    }
  }
}
