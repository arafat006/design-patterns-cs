using Observer_Pattern.Subjects;

namespace Observer_Pattern.Observers
{
  public class NewsAgency : IObserver
  {
    public string AgencyName { get; set; }

    public NewsAgency(string agencyName)
    {
      AgencyName = agencyName;
    }

    public void Update(ISubject subject)
    {
      if (subject is WeatherStation weatherStation)
      {
        Console.WriteLine($"{AgencyName} reporting temperature {weatherStation.Temparature} degree celcius");
        Console.WriteLine();
      }
    }
  }
}
