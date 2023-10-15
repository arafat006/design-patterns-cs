namespace Facade_Pattern.LibraryClasses
{
  public class HardDrive
  {
    public byte[] Read(long lba, int size)
    {
      Console.WriteLine("Hard Drive: Reading data from sector " + lba);
      return new byte[size];
    }
  }
}
