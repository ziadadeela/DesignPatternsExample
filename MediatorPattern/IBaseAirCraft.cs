namespace MediatorPattern
{
    public interface IBaseAirCraft
    {
        string Id { get; }
        void SetMediator(IMediator mediator);
        void TakeOff();
        void Land();
    }
}