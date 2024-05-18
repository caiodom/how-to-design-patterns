using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.SimpleBuilder.Utils
{
    public enum ScreenType
    {
        TOUCH_SCREEN_CAPACITIVE,
        TOUCH_SCREEN_RESISTIVE,
        NON_TOUCH_SCREEN

    };

    public enum Battery
    {
        MAH_1000,
        MAH_1500,
        MAH_2000
    };

    public enum OperationalSystem
    {
        ANDROID,
        IPHONE,
        SYMBIAN
    };
}
