using FactoryMethod.Creator;
using FactoryMethod.Interface;
using FactoryMethod.Models.Tablets;
using FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class TabletFactory : GadgetFactoryMethod
    {
        /* public override IGadget CreateGadget(GadgetBrand gadgetBrand)
         {
             switch (gadgetBrand)
             {
                 case GadgetBrand.XIAOMI:
                     return new XiaomiTablet();
                 case GadgetBrand.APPLE:
                     return new AppleTablet();
                 case GadgetBrand.SAMSUNG:
                     return new SamsungTablet();
                 default:
                     throw new Exception("No available brand was found.")

             }
         }*/
        protected override IGadget CreateGadget(GadgetBrand gadgetBrand)
        {
            switch (gadgetBrand)
            {
                case GadgetBrand.XIAOMI:
                    return new XiaomiTablet();
                case GadgetBrand.APPLE:
                    return new AppleTablet();
                case GadgetBrand.SAMSUNG:
                    return new SamsungTablet();
                default:
                    throw new Exception("No available brand was found.");
 
             }
        }
    }
}
