using System;

namespace ObserverPattern
{
    public class EmailAlertSubscriber : ISubscriber
    {
        public EmailAlertSubscriber(){
    
        }

        public void Update(INotification notification)
        {
            Console.WriteLine($"Email Alert:{notification.Name}");
        }
    }
}