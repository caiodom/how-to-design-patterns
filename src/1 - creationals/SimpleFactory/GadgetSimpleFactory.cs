using SimpleFactory.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class GadgetSimpleFactory
    {
        public static Gadget Create(GadgetType gadgetType)
        {
            Gadget gadget;
            switch (gadgetType)
            {
                case GadgetType.CELLPHONE:
                    gadget=new Cellphone();
                    break;
                case GadgetType.LAPTOP:
                    gadget = new Laptop();
                    break;
                case GadgetType.TABLET:
                    gadget = new Tablet();
                    break;
                default:
                    throw new ApplicationException("No device was created.");
            }

            return gadget;
        }

    }
}
