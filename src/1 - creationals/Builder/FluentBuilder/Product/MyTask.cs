using Builder.FluentBuilder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder.Product
{
    public class MyTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Status Status { get; set; }
    }
}
