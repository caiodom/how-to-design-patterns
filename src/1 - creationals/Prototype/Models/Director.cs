using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Director
    {
        public string Name { get; set; }
        public string Filmography { get; set; }

        public Director Clone()
        {
            return (Director)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Name}, {Filmography}";
        }
    }
}
