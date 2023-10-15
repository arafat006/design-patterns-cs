namespace Abstract_Factory_Pattern.Products.Pizza
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
