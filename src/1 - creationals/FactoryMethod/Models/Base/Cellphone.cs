using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FactoryMethod.Base;
using FactoryMethod.Interface;
using FactoryMethod.Utils;

namespace FactoryMethod.Models.Base
{
    public class Cellphone : BaseGadgetEntity, IGadget
    {
        public Cellphone()
        {
            GadgetType = GadgetType.CELLPHONE;
        }
        public virtual void Delivering()
        {
            Console.WriteLine($"The store is delivering your Cellphone.");
        }

        public virtual void Packaging()
        {
            Console.WriteLine($"The store is packaging your Cellphone.");
        }
    }
}
