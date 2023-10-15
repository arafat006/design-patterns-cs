namespace Adapter_Pattern.BaseClasses
{
  public interface ISquare
  {
    void DrawSquare();
  }

  public class Square : ISquare
  {
    public void DrawSquare()
    {
      Console.WriteLine("Drawing Square");
    }
  }
}
