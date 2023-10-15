using Facade_Pattern.LibraryClasses;

namespace Facade_Pattern.FacadeClasses
{
  public class ComputerFacade
  {
    private CPU cpu;
    private Memory memory;
    private HardDrive hardDrive;

    public ComputerFacade()
    {
      cpu = new CPU();
      memory = new Memory();
      hardDrive = new HardDrive();
    }

    public void Start()
    {
      cpu.Freeze();
      memory.Load(0, hardDrive.Read(0, 1024));
      cpu.Jump(0);
      cpu.Execute();
    }

    public void ShutDown()
    {
      Console.WriteLine("Shutting down the computer...");
    }
  }
}
