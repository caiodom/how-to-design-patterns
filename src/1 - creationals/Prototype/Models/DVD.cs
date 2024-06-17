using Prototype.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class DVD : LibraryItem
    {
        public Director Director { get; set; }
        public TimeSpan Duration { get; set; }

        public override LibraryItem Clone()
        {
            DVD clone = (DVD)this.MemberwiseClone();
            clone.Director = this.Director.Clone();
            return clone;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Director: [{Director}], Duration: {Duration}, ID: {Id}";
        }
    }
}
