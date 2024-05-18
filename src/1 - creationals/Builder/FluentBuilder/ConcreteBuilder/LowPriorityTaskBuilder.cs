using Builder.FluentBuilder.Builder;
using Builder.FluentBuilder.Product;
using Builder.FluentBuilder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder.ConcreteBuilder
{
    public class LowPriorityTaskBuilder : ITaskBuilder
    {
        private MyTask task;
        //private MyTask task = new MyTask();
        public LowPriorityTaskBuilder()
        {
            task = new MyTask();
        }

        public ITaskBuilder WithTitle()
        {
            task.Title = "Create Application with Builder Pattern (LOW PRIORITY)";
            return this;
        }

        public ITaskBuilder WithDescription()
        {
            task.Description = "Implement the Builder pattern";
            return this;
        }

        public ITaskBuilder WithPriority()
        {
            task.Priority = Priority.LOW;
            return this;
        }

        public ITaskBuilder WithExpirationDate()
        {
            task.ExpirationDate = DateTime.Now.AddDays(15);
            return this;
        }

        public ITaskBuilder WithStatus()
        {
            task.Status = Status.PENDING;
            return this;
        }

        public MyTask Build()
        {
            return task;
        }
    }
}
