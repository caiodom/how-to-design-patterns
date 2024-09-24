
using Mediator.Colleagues;
using Mediator.Mediator;

ChatRoom chatRoom = new ChatRoom();


User bob = new ConcreteUser(chatRoom, "Bob");
User cindy = new ConcreteUser(chatRoom, "Cindy");
User joe = new ConcreteUser(chatRoom, "Joe");
User james = new ConcreteUser(chatRoom, "James");

chatRoom.RegisterUser(bob);
chatRoom.RegisterUser(cindy);
chatRoom.RegisterUser(joe);
chatRoom.RegisterUser(james);

bob.SendMessage("Hello everyone!");
cindy.SendMessage("Hello!!!");
joe.SendMessage("What's Up!!");
james.SendMessage("Hi Everyone!");

Console.Read();

