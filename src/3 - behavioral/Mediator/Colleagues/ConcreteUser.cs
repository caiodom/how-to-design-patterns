using Mediator.Mediator;

namespace Mediator.Colleagues
{
    //colleague component
    public class ConcreteUser : User
    {

        public ConcreteUser(IMediator mediator, string name) : base(mediator, name) { }
        public override void SendMessage(string message)
        {
            Console.WriteLine($"{_name} is sending: {message}");
            _mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message, User sender)
        {
            Console.WriteLine($"{_name} received from {sender.GetName()}: {message}");
        }

        public override string GetName()
        {
            return _name;
        }
    }
}
