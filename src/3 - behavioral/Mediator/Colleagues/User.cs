using Mediator.Mediator;

namespace Mediator.Colleagues
{
    //colleague component
    public abstract class User
    {
        protected IMediator _mediator;
        protected string _name;

        protected User(IMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }


        public abstract void SendMessage(string message);

        public abstract void ReceiveMessage(string message, User sender);
        public abstract string GetName();
    }
}
