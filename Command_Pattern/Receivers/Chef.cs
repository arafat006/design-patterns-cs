namespace Command_Pattern.Receivers
{
  public class Chef
  {
    public void Cook()
    {
      Console.WriteLine("Chef is cooking the order.");
    }

    public void CancelCooking()
    {
      Console.WriteLine("Chef cancels the order.");
    }
  }
}
