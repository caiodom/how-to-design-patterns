using Builder.FluentBuilder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder.Builder
{
    public interface ITaskBuilder
    {
        ITaskBuilder WithTitle();
        ITaskBuilder WithDescription();
        ITaskBuilder WithPriority();
        ITaskBuilder WithExpirationDate();
        ITaskBuilder WithStatus();
        MyTask Build();
    }
}
