using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.ClientCode();
        }
    }

    class Client
    {
        public static void ClientCode()
        {
            IMediator mediator = new AirTrafficController();
            Helicopter helicopter = new Helicopter(mediator);
            AirPlane airPlane = new AirPlane(mediator);

            helicopter.Land();

            Console.WriteLine();

            airPlane.Land();
        }
    }
}