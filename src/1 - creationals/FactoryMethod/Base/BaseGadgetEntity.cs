using FactoryMethod.Interface;
using FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Base
{
    public abstract class BaseGadgetEntity
    {
        protected GadgetBrand GadgetBrand { get; set; }
        protected GadgetType GadgetType { get; set; }

    }
}
