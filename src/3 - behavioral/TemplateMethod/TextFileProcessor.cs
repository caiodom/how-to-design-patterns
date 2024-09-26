using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class TextFileProcessor : FileProcessor
    {
        public override void CloseFile()
        {
            Console.WriteLine("Closing text file.");
        }

        public override void OpenFile()
        {
            Console.WriteLine("Opening text file...");
        }

        public override void ProcessFile()
        {
            Console.WriteLine("Processing text file content...");
        }
    }
}
