namespace Factory_Pattern.Products
{
  //Product - non veg pizza
  public class NonVegPizza : IPizza
  {
    public string Eat()
    {
      return "Eating non-veg pizza";
    }
  }
}
