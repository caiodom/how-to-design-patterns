using FactoryMethod.Creator;
using FactoryMethod.Interface;
using FactoryMethod.Models.Laptops;
using FactoryMethod.Models.Tablets;
using FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class LaptopFactory : GadgetFactoryMethod
    {
        /* public override IGadget CreateGadget(GadgetBrand gadgetBrand)
         {
             switch (gadgetBrand)
             {
                 case GadgetBrand.XIAOMI:
                     return new XiaomiLaptop();
                 case GadgetBrand.APPLE:
                     return new AppleLaptop();
                 case GadgetBrand.SAMSUNG:
                     return new SamsungLaptop();
                 default:
                     throw new Exception("No available brand was found.")

             }
         }*/
        protected override IGadget CreateGadget(GadgetBrand gadgetBrand)
        {
            switch (gadgetBrand)
            {
                case GadgetBrand.XIAOMI:
                    return new XiaomiLaptop();
                case GadgetBrand.APPLE:
                    return new AppleLaptop();
                case GadgetBrand.SAMSUNG:
                    return new SamsungLaptop();
                default:
                    throw new Exception("No available brand was found.");
 
             }
        }
    }
}
