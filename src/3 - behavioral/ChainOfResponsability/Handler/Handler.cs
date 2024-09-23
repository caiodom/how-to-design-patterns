using ChainOfResponsability.Handler.Interfaces;


namespace ChainOfResponsability.Handler
{
    public abstract class Handler:IHandler
    {
        protected IHandler next;
        public abstract void HandleRequest(RefundRequest request);

        public void SetNext(IHandler handler)
        {
            next = handler;
        }
    }
}
