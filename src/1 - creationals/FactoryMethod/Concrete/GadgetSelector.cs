using FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public static class GadgetSelector
    {
        public static GadgetType GetGadgetType(string chosenGadget)
        {
            GadgetType gadgetType;
            switch (chosenGadget)
            {
                case "C":
                    gadgetType = GadgetType.CELLPHONE;
                    break;
                case "L":
                    gadgetType = GadgetType.LAPTOP;
                    break;
                case "T":
                    gadgetType = GadgetType.TABLET;
                    break;
                default:
                    throw new Exception($"The type {chosenGadget} does not exist");
            }

            return gadgetType;
        }


        public static GadgetBrand GetGadgetBrand(string brand)
        {
            GadgetBrand gadgetBrand;
            switch (brand)
            {
                case "APPLE":
                    gadgetBrand = GadgetBrand.APPLE;
                    break;
                case "XIAOMI":
                    gadgetBrand = GadgetBrand.XIAOMI;
                    break;
                case "SAMSUNG":
                    gadgetBrand = GadgetBrand.SAMSUNG;
                    break;
                default:
                    throw new Exception($"The brand {brand} does not exist");
            }

            return gadgetBrand;
        }
    }
}
