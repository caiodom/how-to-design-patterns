using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class Gadget
    {
        public string Name { get; set; }
        public abstract void Packaging();
        public abstract void Delivering();
    }
}
