using System.Collections.Generic;

namespace ObserverPattern
{
    public interface IPublisher
    {
        void Subscribe(ISubscriber subscriber);
        void Subscribe(List<ISubscriber> subscribers);
        void UnSubscribe(ISubscriber subscriber);
        void Notify(INotification notification);
    }
}