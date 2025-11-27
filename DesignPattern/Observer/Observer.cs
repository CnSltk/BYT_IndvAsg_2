// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
public class ConcreteObserver(string userName) : IObserver
{
    //Hold the observer's name
    public string UserName { get; } = userName;

    //Register the Observer with the Subject
    public void AddSubscriber(ISubject subject)
    {
        subject.RegisterObserver(this);
    }
    //Remove the Observer from the Subject
    public void RemoveSubscriber(ISubject subject)
    {
        subject.RemoveObserver(this);
    }

    //Get notifications from the Subject
    public void Update(string availability)
    {
        Console.WriteLine(
            $"Notification to {UserName}: Product availability changed to \"{availability}\".");
    }
}
}
