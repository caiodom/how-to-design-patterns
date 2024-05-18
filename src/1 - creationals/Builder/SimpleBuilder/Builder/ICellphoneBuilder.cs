using Builder.SimpleBuilder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.SimpleBuilder.Builder
{
    interface ICellphoneBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOS();
        Cellphone Phone { get; }
    }
}
