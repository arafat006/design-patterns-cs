namespace Decorator_Pattern.Products
{
  public interface IPizza
  {
    void Prepare();
  }

  public class BasePizza : IPizza
  {
    public void Prepare()
    {
      Console.WriteLine("Pizza is prepared");
    }
  }
}
