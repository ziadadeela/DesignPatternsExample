namespace MediatorPattern
{
    public class Helicopter : BaseAirCraft
    {
        public override string Id => "Helicopter";
        
        public Helicopter(IMediator mediator) : base(mediator)
        {
            
        }
    }
}