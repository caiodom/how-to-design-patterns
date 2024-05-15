using SimpleFactory.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
     class GadgetTypeSelector
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
    }
}
