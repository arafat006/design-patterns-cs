namespace Facade_Pattern.LibraryClasses
{
  public class Memory
  {
    public void Load(long position, byte[] data)
    {
      Console.WriteLine("Memory: Loading data to address " + position);
    }
  }
}
