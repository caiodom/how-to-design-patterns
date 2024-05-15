using FactoryMethod.Interface;
using FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    public abstract class GadgetFactoryMethod
    {
        public IGadget ChooseTheBrand(GadgetBrand gadgetBrand)
        {
            IGadget gadget;
            gadget = CreateGadget(gadgetBrand);
            return gadget;
        }

        protected abstract IGadget CreateGadget(GadgetBrand gadgetBrand);
    }
}
