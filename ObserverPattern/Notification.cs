using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern
{
    public class Notification : INotification
    {
        public string Name { get; set; }
        public Dictionary<string, string> Attributes { get; set; }

        public string StringifyAttributes()
        {
            return Attributes
                .Select(attr => $"{attr.Key}: {attr.Value}")
                .Aggregate((a, b) => a + ", " + b);
        }
    }
}