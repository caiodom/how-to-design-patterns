using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Laptop:Gadget
    {
        public Laptop()
        {
            Name = "Laptop";
        }
        public override void Packaging()
        {
            Console.WriteLine($"The store is packaging your {Name}.");
        }

        public override void Delivering()
        {
            Console.WriteLine($"The store is delivering your {Name}.");
        }



    }
}
