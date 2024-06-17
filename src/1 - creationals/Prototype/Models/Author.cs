using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Author
    {
        public string Name { get; set; }
        public string Biography { get; set; }

       public Author Clone()
        {
            return (Author)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Name}, {Biography}";
        }

    }
}
