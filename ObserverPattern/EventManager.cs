using System.Collections.Generic;

namespace ObserverPattern
{
    public class EventManager: IPublisher
    {
        private List<ISubscriber> _subscribers = new ();
        private IPublisher _publisherImplementation;

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Subscribe(List<ISubscriber> subscribers)
        {
            foreach (var subscriber in subscribers)
            {
                _subscribers.Add(subscriber);
            }
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify(INotification notification)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(notification);
            }
        }
    }
}