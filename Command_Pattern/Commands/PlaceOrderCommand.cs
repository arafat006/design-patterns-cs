using Command_Pattern.Receivers;

namespace Command_Pattern.Commands
{
  public class PlaceOrderCommand : ICommand
  {
    private Chef chef;

    public PlaceOrderCommand(Chef chef)
    {
      this.chef = chef;
    }

    public void Execute()
    {
      chef.Cook();
    }
  }
}
