using System.Collections.Generic;

namespace ObserverPattern
{
    public interface INotification
    {
        string Name { get; set; }
        
        Dictionary<string, string> Attributes { get; set; }

        string StringifyAttributes();
    }
}