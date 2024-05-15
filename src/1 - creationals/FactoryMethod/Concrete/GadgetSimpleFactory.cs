using FactoryMethod.Creator;
using FactoryMethod.Interface;
using FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public static class GadgetSimpleFactory 
    {
        public static  GadgetFactoryMethod CreateGadget(GadgetType gadgetType)
        {
            GadgetFactoryMethod gadget;
            switch (gadgetType) 
            {
                case GadgetType.CELLPHONE:
                    gadget= new CellphoneFactory();
                    break;
                case GadgetType.LAPTOP:
                    gadget= new LaptopFactory();
                    break;
                case GadgetType.TABLET:
                    gadget= new TabletFactory();
                    break;
                default:
                    throw new Exception("No available brand was found.");

            }
            return gadget;
        }
    }
}
