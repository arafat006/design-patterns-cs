namespace Abstract_Factory_Pattern.Products.Burger
{
  //Product - veg burger
  public class VegBurger : IBurger
  {
    public string Eat()
    {
      return "Eating veg burger";
    }
  }
}
