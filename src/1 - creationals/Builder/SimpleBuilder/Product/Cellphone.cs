using Builder.SimpleBuilder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.SimpleBuilder.Product
{
     class Cellphone
    {
        public Cellphone(string name)
        {
            CellphoneName = name;
        }

        public string CellphoneName { get; set; }

        public ScreenType ScreenType { get; set; }

        public Battery Battery { get; set; }

        public OperationalSystem OperationalSystem { get; set; }

        public override string ToString()
        {
            return string.Format($"Name: {CellphoneName}\n Screen Type: {ScreenType}" +
                $"\nBattery {Battery}\nOS: {OperationalSystem}");
        }
    }
}
