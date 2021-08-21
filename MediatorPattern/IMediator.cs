namespace MediatorPattern
{
    public interface IMediator
    {
        void Notify(IBaseAirCraft sender, string ev);
    }
}