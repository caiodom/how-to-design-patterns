using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Base
{
    public abstract class LibraryItem:IPrototype<LibraryItem>
    {
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Id { get; set; }

        public abstract LibraryItem Clone();

    }
  
}
