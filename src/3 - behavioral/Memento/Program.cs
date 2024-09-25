//client

using Memento;
using Memento.Originator;

ICircleShape circleOriginator = new Circle();
Caretaker caretaker = new Caretaker();

circleOriginator.Draw(10);
caretaker.AddMemento(circleOriginator.SaveToMemento());
Console.WriteLine("\nCircle with radius 10:");
Console.WriteLine(circleOriginator.Get());



circleOriginator.Draw(5);
caretaker.AddMemento(circleOriginator.SaveToMemento());
Console.WriteLine("\nCircle with radius 5:");
Console.WriteLine(circleOriginator.Get());



circleOriginator.Draw(15);
Console.WriteLine("\nCircle with radius 15:");
Console.WriteLine(circleOriginator.Get());



//Restore
Console.WriteLine("\nRestoring Circle to radius 10:");
Console.WriteLine($"\n\n\n {circleOriginator.RestoreToMemento(caretaker.GetMemento(0))}");


//Restore
Console.WriteLine("\nRestoring Circle to radius 5:");
Console.WriteLine($"\n\n\n {circleOriginator.RestoreToMemento(caretaker.GetMemento(1))}");
