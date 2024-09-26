using State.Context;

Order order = new Order();

Console.WriteLine($"Current Status: {order.GetStatus()}");
order.Proceed(); 

// Estado: BeingPrepared
Console.WriteLine($"Current Status: {order.GetStatus()}");
order.Proceed(); 

// Estado: ReadyForDelivery
Console.WriteLine($"Current Status: {order.GetStatus()}");
order.Cancel(); 

order.Proceed(); 

// Estado: Delivered
Console.WriteLine($"Current Status: {order.GetStatus()}");
order.Cancel(); 