

namespace ChainOfResponsability.Handler.Interfaces
{
    public interface IHandler
    {

        void SetNext(IHandler handler);

        void HandleRequest(RefundRequest request);
    }
}
