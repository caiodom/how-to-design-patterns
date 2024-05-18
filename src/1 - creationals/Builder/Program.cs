// See https://aka.ms/new-console-template for more information
using Builder.FluentBuilder.ConcreteBuilder;
using Builder.FluentBuilder.Director;
using Builder.SimpleBuilder;
using Builder.SimpleBuilder.Builder;
using Builder.SimpleBuilder.ConcreteBuilder;




Console.WriteLine("============Cellphone Builder===============\n");
BuilderStart();


Console.WriteLine("\n\n+++++++++ TASK CREATOR +++++++++++\n");
FluentBuilderStart();
Console.ReadLine();




static void BuilderStart()
{
    
    Factory firstFactory = new Factory();

    
    ICellphoneBuilder cellphoneBuilder = null;


    cellphoneBuilder = new AndroidBuilder();
    firstFactory.Build(cellphoneBuilder);
    Console.WriteLine($"New cell phone was created:\n\n{cellphoneBuilder.Phone.ToString()}");

    
    cellphoneBuilder = new IPhoneBuilder();
    firstFactory.Build(cellphoneBuilder);
    Console.WriteLine($"New cell phone was created:\n\n{cellphoneBuilder.Phone.ToString()}");
}
 static void FluentBuilderStart()
{
    MyTaskManager director = new MyTaskManager();

    LowPriorityTaskBuilder lowPriorityTaskBuilder = new LowPriorityTaskBuilder();
    HighPriorityTaskBuilder highPriorityTaskBuilder = new HighPriorityTaskBuilder();

    director.TaskCreator(lowPriorityTaskBuilder);
    director.PrintTask();
    director.TaskCreator(highPriorityTaskBuilder);
    director.PrintTask();
}