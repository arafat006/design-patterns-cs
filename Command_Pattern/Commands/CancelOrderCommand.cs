using Command_Pattern.Receivers;

namespace Command_Pattern.Commands
{
  public class CancelOrderCommand : ICommand
  {
    private Chef chef;

    public CancelOrderCommand(Chef chef)
    {
      this.chef = chef;
    }

    public void Execute()
    {
      chef.CancelCooking();
    }
  }
}
