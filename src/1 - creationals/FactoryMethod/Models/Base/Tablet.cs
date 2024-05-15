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
    public class Tablet : BaseGadgetEntity, IGadget
    {
        public Tablet()
        {
            GadgetType = GadgetType.TABLET;
        }
        public virtual void Delivering()
        {
            Console.WriteLine($"The store is delivering your Tablet.");
        }

        public virtual void Packaging()
        {
            Console.WriteLine($"The store is packaging your Tablet.");
        }
    }
}
