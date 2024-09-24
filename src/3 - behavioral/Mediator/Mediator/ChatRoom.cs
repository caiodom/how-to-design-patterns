using Mediator.Colleagues;

namespace Mediator.Mediator
{
    //Concrete Mediator
    public class ChatRoom : IMediator
    {
        private readonly List<User> _users;
        public ChatRoom()
        {
            _users = new List<User>();
        }

        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                // Não enviar a mensagem para o remetente
                if (user != sender)
                {
                    user.ReceiveMessage(message, sender);
                }
            }
        }
    }
}
