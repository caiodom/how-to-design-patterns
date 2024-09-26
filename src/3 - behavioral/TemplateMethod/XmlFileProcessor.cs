using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class XmlFileProcessor : FileProcessor
    {
        public override void CloseFile()
        {
            Console.WriteLine("Closing XML file.");
        }

        public override void OpenFile()
        {
            Console.WriteLine("Opening XML file...");
        }

        public override void ProcessFile()
        {
            Console.WriteLine("Processing XML file content...");
        }
    }
}
