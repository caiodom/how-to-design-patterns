using Prototype.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Book:LibraryItem
    {
        public Author Author { get; set; }
        public string Publisher { get; set; }

        public override LibraryItem Clone()
        {
            Book clone=(Book)this.MemberwiseClone();
            clone.Author = Author.Clone();
            return clone;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: [{Author}], Publisher: {Publisher}, ID: {Id}";
        }
    }
}
