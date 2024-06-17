using Prototype.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public Editor Editor { get; set; }
        public override LibraryItem Clone()
        {
           Magazine clone= (Magazine)this.MemberwiseClone();
            clone.Editor = Editor.Clone();
            return clone;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Issue: {IssueNumber}, Editor: [{Editor}], ID: {Id}";
        }

    }
}
