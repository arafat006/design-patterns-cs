using Observer_Pattern.Subjects;

namespace Observer_Pattern.Observers
{
  public interface IObserver
  {
    void Update(ISubject subject);
  }
}
