using Mediator.Colleagues;

namespace Mediator.Mediator
{
    //Mediator
    public interface IMediator
    {
        void SendMessage(string message, User sender);
    }
}
