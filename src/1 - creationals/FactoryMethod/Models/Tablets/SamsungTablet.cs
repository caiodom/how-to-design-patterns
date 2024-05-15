using FactoryMethod.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models.Tablets
{
    public class SamsungTablet:Tablet
    {
        public override void Packaging()
        {
            Console.WriteLine($"The store is packing your Samsung Tablet.");
        }

        public override void Delivering()
        {
            Console.WriteLine($"The store is delivering your Samsung Tablet.");
        }
    }
}
