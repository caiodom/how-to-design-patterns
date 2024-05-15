using FactoryMethod.Creator;
using FactoryMethod.Interface;
using FactoryMethod.Models.Cellphones;
using FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class CellphoneFactory : GadgetFactoryMethod
    {
        /* public override IGadget CreateGadget(GadgetBrand gadgetBrand)
         {
            switch (gadgetBrand)
             {
                 case GadgetBrand.XIAOMI:
                     return new XiaomiCellPhone();
                 case GadgetBrand.APPLE:
                     return new AppleCellphone();
                 case GadgetBrand.SAMSUNG:
                     return new SamsungCellphone();
                 default:
                     throw new Exception("No available brand was found.")

             }
         }*/
        protected override IGadget CreateGadget(GadgetBrand gadgetBrand)
        {
            switch (gadgetBrand)
            {
                case GadgetBrand.XIAOMI:
                    return new XiaomiCellPhone();
                case GadgetBrand.APPLE:
                    return new AppleCellphone();
                case GadgetBrand.SAMSUNG:
                    return new SamsungCellphone();
                default:
                    throw new Exception("No available brand was found.");

             }
        }
    }
}
