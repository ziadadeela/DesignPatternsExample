namespace MediatorPattern
{
    public class AirPlane : BaseAirCraft
    {
        public override string Id => "AirPlane";

        public AirPlane(IMediator mediator) : base(mediator)
        {
            
        }
    }
}