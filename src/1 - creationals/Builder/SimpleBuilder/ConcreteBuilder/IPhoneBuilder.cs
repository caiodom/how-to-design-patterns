using Builder.SimpleBuilder.Builder;
using Builder.SimpleBuilder.Product;
using Builder.SimpleBuilder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Builder.SimpleBuilder.ConcreteBuilder
{
    class IPhoneBuilder : ICellphoneBuilder
    {
        Cellphone phone;
        public IPhoneBuilder()
        {
            phone = new Cellphone("IPhone");
        }
        public Cellphone Phone => phone;
        public void BuildBattery()
        {
           phone.Battery = Battery.MAH_2000;
        }

        public void BuildOS()
        {
            phone.OperationalSystem = OperationalSystem.IPHONE;
        }

        public void BuildScreen()
        {
            phone.ScreenType = ScreenType.TOUCH_SCREEN_CAPACITIVE;
        }
    }
}
