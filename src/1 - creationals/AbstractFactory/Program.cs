using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

Console.WriteLine("Show me your Cars!!");
IFactory factory = new Factory();
ICarFactory carFactory = factory.CreateCarFactory();
IVehicle sedanCar = carFactory.CreateSedan();
Console.WriteLine(sedanCar.ShowDetails());
IVehicle suvCar=carFactory.CreateSUV();
Console.WriteLine(suvCar.ShowDetails());
Console.WriteLine("Show me your Motocycles!!");
IMotocycleFactory motocycleFactory= factory.CreateMotocycleFactory();
IVehicle cruiserMotocycle = motocycleFactory.CreateCruiser();
Console.WriteLine(cruiserMotocycle.ShowDetails());
IVehicle sportbikeMotocycle = motocycleFactory.CreateSportBike();
Console.WriteLine(sportbikeMotocycle.ShowDetails());

Console.WriteLine("Bye Bye!!");
Console.ReadLine();


