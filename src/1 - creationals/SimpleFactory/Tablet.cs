using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class Tablet : Gadget
    {
        public Tablet()
        {
            Name = "Tablet";
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
