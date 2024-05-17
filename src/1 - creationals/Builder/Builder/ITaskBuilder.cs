using Builder.Product;
using Builder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
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
