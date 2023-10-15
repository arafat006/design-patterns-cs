namespace Adapter_Pattern.Adaptees
{
  public interface ICircle
  {
    void DrawCircle();
  }

  public class Circle : ICircle
  {
    public void DrawCircle()
    {
      Console.WriteLine("Drawing Circle");
    }
  }
}
