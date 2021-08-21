using System;

namespace MediatorPattern
{
    public class BaseAirCraft: IBaseAirCraft
    {
        public virtual string Id =>"BaseAirCraft";

        protected IMediator Mediator;
        
        protected BaseAirCraft(IMediator mediator = null)
        {
            this.Mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.Mediator = mediator;
        }

        public void TakeOff()
        {
            Console.WriteLine($"Me,{Id}, wanna Take OoooooooooOf!");
            this.Mediator.Notify(this,"TakeOff");
        }
        
        public void Land()
        {
            Console.WriteLine($"Me,{Id}, wanna Laaaaaaand!");
            this.Mediator.Notify(this,"Land");
        }

    }
}