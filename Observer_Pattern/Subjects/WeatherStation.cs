﻿using Observer_Pattern.Observers;

namespace Observer_Pattern.Subjects
{
  public interface ISubject
  {
    void Attach(IObserver observer);
    void Notify();
  }

  public class WeatherStation : ISubject
  {
    private List<IObserver> _observers;
    public float Temparature
    {
      get { return _temperature; }
      set { 
        _temperature = value;
        Notify();
      }
    }
    private float _temperature;

    public WeatherStation()
    {
      _observers = new List<IObserver>();
    }

    public void Attach(IObserver observer)
    {
      _observers.Add(observer);
    }
     
    public void Notify()
    {
      _observers.ForEach(o => o.Update(this));
    }
  }
}
