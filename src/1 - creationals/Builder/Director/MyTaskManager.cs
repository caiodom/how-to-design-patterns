using Builder.Builder;
using Builder.ConcreteBuilder;
using Builder.Product;
using Builder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    public class MyTaskManager
    {
        private MyTask task;

        public void TaskCreator(ITaskBuilder builder)
        {
           task = builder.WithTitle()
                   .WithDescription()
                   .WithPriority()
                   .WithExpirationDate()
                   .WithStatus()
                   .Build();
                   
           
        }

        public void PrintTask()
        {
            Console.WriteLine($"title:{task.Title} \n" +
                              $"description:{task.Description} \n" +
                              $"priority:{Translators.PriorityTranslater(task.Priority)} \n " +
                              $"status:{Translators.StatusTranslater(task.Status)} \n" +
                              $"expiration date:{task.ExpirationDate} \n");

           
        }                       

    }
}
