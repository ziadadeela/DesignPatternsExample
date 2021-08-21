namespace ObserverPattern
{
    public interface ISubscriber
    {
        void Update(INotification notification);
    }
}