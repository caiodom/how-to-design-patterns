using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Models.Base;

namespace FactoryMethod.Models.Cellphones
{
    public class XiaomiCellPhone : Cellphone
    {
        public override void Packaging()
        {
            Console.WriteLine($"The store is packing your Xiaomi Cellphone.");
        }

        public override void Delivering()
        {
            Console.WriteLine($"The store is delivering your Xiaomi Cellphone.");
        }
    }
}
