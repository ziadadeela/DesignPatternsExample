using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    public class AirTrafficController : IMediator
    {
        private bool _isOccupied = false ;

        private Dictionary<string, Action<IBaseAirCraft>> _handlers;
        public AirTrafficController()
        {
            _handlers = new Dictionary<string, Action<IBaseAirCraft>>
            {
                {"Land", HandleLanding},
                {"TakeOff", HandleTakingOff},
            };
        } 

        public void Notify(IBaseAirCraft sender, string action)
        {
            if (_handlers.TryGetValue(action, out var handler))
            {
                handler(sender);
            }
            else
            {
                Console.WriteLine($"Invalid Action Supplied: {action}");
            }
        }

        private void HandleLanding(IBaseAirCraft sender)
        {
            if (_isOccupied)
            {
                Console.WriteLine($"AirTrafficController: Airport is already occupied :/");
                return;
            }
            Console.WriteLine($"AirTrafficController: {sender.Id} has LANDED.");
            _isOccupied = true;
        }
        private void HandleTakingOff(IBaseAirCraft sender)
        {
            if (!_isOccupied)
            {
                Console.WriteLine($"AirTrafficController: No Plane to take off :O");
                return;
            }
            Console.WriteLine($"AirTrafficController: {sender.Id} has TAKEN OFF.");
            _isOccupied = false;
        }
    }

}