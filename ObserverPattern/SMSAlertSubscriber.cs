using System;

namespace ObserverPattern
{
    public class SmsAlertSubscriber : ISubscriber
    {
        public SmsAlertSubscriber(){
    
        }

        public void Update(INotification notification)
        {
            Console.WriteLine($"SMS Alert:{notification.Name}");
            Console.WriteLine($"Attributes:\n{notification.StringifyAttributes()}");
        }
    }
}