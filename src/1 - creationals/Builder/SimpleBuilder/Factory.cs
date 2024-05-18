using Builder.SimpleBuilder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.SimpleBuilder
{
    class Factory
    {
        public void Build(ICellphoneBuilder cellphoneBuilder)
        {
            cellphoneBuilder.BuildBattery();
            cellphoneBuilder.BuildOS();
            cellphoneBuilder.BuildScreen();
        }
    }
}
