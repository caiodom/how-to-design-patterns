using Builder.Builder;
using Builder.Product;
using Builder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBuilder
{
    public class HighPriorityTaskBuilder : ITaskBuilder
    {
        private MyTask task;
        //private MyTask task = new MyTask();
        public HighPriorityTaskBuilder()
        {
            task = new MyTask();
        }

        public ITaskBuilder WithTitle()
        {
            task.Title = "Create Application with Builder Pattern (HIGH PRIORITY)";
            return this;
        }

        public ITaskBuilder WithDescription()
        {
            task.Description= "Implement the Builder pattern";
            return this;
        }

        public ITaskBuilder WithPriority()
        {
            task.Priority = Priority.HIGH;
            return this;
        }

        public ITaskBuilder WithExpirationDate()
        {
            task.ExpirationDate = DateTime.Now.AddDays(7);
            return this;
        }

        public ITaskBuilder WithStatus()
        {
            task.Status= Status.PENDING;
            return this;
        }

        public MyTask Build()
        {
            return task;
        }
    }
}
