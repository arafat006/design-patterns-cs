namespace Abstract_Factory_Pattern.Products.Burger
{
  //Product - non veg burger
  public class NonVegBurger : IBurger
  {
    public string Eat()
    {
      return "Eating non-veg burger";
    }
  }
}
