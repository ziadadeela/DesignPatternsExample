using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subscribers = new List<ISubscriber>()
            {
                new EmailAlertSubscriber(),
                new SmsAlertSubscriber()
            };
            IPublisher eventManager = new EventManager();

            eventManager.Subscribe(subscribers);
            var notification = new Notification()
            {
                Name = "New Friend Request!",
                Attributes = new Dictionary<string, string>
                {
                    { "Name", "Ziad :D" }
                }
            };
            eventManager.Notify(notification);
        }
    }
}