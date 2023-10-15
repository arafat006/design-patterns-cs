using Command_Pattern.Commands;

namespace Command_Pattern.Invokers
{
  public class Waiter
  {
    private ICommand command;

    public void SetCommand(ICommand command)
    {
      this.command = command;
    }

    public void ExecuteCommand()
    {
      command.Execute();
    }
  }
}
