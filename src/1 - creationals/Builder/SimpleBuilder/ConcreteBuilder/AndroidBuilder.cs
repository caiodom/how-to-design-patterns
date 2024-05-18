using Builder.SimpleBuilder.Builder;
using Builder.SimpleBuilder.Product;
using Builder.SimpleBuilder.Utils;
using static System.Net.Mime.MediaTypeNames;


namespace Builder.SimpleBuilder.ConcreteBuilder
{
    class AndroidBuilder : ICellphoneBuilder
    {
        public Cellphone phone;
        public AndroidBuilder()
        {
            phone = new Cellphone("Android");
        }

        public Cellphone Phone
        {
            get { return phone; }
        }

        public void BuildBattery()
        {
            phone.Battery = Battery.MAH_1500;
        }

        public void BuildOS()
        {
            phone.OperationalSystem = OperationalSystem.ANDROID;
        }

        public void BuildScreen()
        {
            phone.ScreenType = ScreenType.TOUCH_SCREEN_CAPACITIVE;
        }
    }
}
