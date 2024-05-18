
using Builder.FluentBuilder.Builder;
using Builder.FluentBuilder.Product;
using Builder.FluentBuilder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder.Director
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
