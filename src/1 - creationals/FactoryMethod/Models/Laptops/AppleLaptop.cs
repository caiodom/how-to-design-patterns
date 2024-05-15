using FactoryMethod.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models.Laptops
{
    public class AppleLaptop:Laptop
    {
        public override void Packaging()
        {
            Console.WriteLine($"The store is packing your Apple Laptop.");
        }

        public override void Delivering()
        {
            Console.WriteLine($"The store is delivering your Apple Laptop.");
        }
    }
}
