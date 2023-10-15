namespace Factory_Pattern.Products
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
