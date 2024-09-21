
using Proxy;
//client


IDatabaseAccess databaseProxy = new DatabaseAccessProxy();
Console.WriteLine("Testing with authorized user 'admin':");
databaseProxy.RequestData("admin");


Console.WriteLine("\nTesting with unauthorized user 'guest':");
databaseProxy.RequestData("guest");


Console.WriteLine("\nTesting with authorized user 'manager':");
databaseProxy.RequestData("manager");


Console.WriteLine("\nTesting with unauthorized user 'anonymous':");
databaseProxy.RequestData("anonymous");