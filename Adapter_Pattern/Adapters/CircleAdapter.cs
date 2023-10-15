using Adapter_Pattern.Adaptees;
using Adapter_Pattern.BaseClasses;

namespace Adapter_Pattern.Adapters
{
  public class CircleAdapter : ISquare
  {
    private readonly ICircle circle;

    public CircleAdapter(ICircle circle)
    {
      this.circle = circle;
    }

    public void DrawSquare() 
    {
      circle.DrawCircle();
    }
  }
}
