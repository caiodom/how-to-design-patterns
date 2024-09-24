using Mediator.Colleagues;

namespace Mediator.Mediator
{
    //interface mediator
    public interface IMediator
    {
        void SendMessage(string message, User sender);
    }
}
