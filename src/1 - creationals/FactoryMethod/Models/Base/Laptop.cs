using FactoryMethod.Base;
using FactoryMethod.Interface;
using FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models.Base
{
    public class Laptop : BaseGadgetEntity, IGadget
    {
        public Laptop()
        {
            GadgetType = GadgetType.LAPTOP;
        }
        public virtual void Delivering()
        {
            Console.WriteLine($"The store is delivering your Laptop.");
        }

        public virtual void Packaging()
        {
            Console.WriteLine($"The store is packaging your Laptop.");
        }
    }
}
