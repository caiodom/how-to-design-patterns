// See https://aka.ms/new-console-template for more information
using Builder.ConcreteBuilder;
using Builder.Director;

Console.WriteLine("+++++++++ TASK CREATOR +++++++++++");

MyTaskManager director= new MyTaskManager();

LowPriorityTaskBuilder lowPriorityTaskBuilder= new LowPriorityTaskBuilder();
HighPriorityTaskBuilder highPriorityTaskBuilder= new HighPriorityTaskBuilder();

director.TaskCreator(lowPriorityTaskBuilder);
director.PrintTask();
director.TaskCreator(highPriorityTaskBuilder);
director.PrintTask();

Console.ReadLine();



