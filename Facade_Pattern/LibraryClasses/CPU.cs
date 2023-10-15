namespace Facade_Pattern.LibraryClasses
{
  public class CPU
  {
    public void Freeze()
    {
      Console.WriteLine("CPU: Freezing...");
    }

    public void Jump(long position)
    {
      Console.WriteLine("CPU: Jumping to address " + position);
    }

    public void Execute()
    {
      Console.WriteLine("CPU: Executing commands...");
    }
  }
}
