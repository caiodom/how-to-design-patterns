using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Editor
    {
        public string Name { get; set; }
        public string Experience { get; set; }

        public Editor Clone()
        {
            return (Editor)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Name}, {Experience}";
        }
    }
}
