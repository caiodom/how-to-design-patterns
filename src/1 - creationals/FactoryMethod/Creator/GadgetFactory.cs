using FactoryMethod.Interface;
using FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    public abstract class GadgetFactory
    {
        public abstract IGadget CreateGadget(GadgetBrand gadgetBrand);
    }
}
