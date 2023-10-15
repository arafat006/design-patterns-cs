namespace Abstract_Factory_Pattern.Products.Pizza
{
  //Product - veg pizza
  public class VegPizza : IPizza
  {
    public string Eat()
    {
      return "Eating veg pizza";
    }
  }
}
