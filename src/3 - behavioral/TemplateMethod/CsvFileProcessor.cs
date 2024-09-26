using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class CsvFileProcessor : FileProcessor
    {
        public override void CloseFile()
        {
            Console.WriteLine("Closing CSV file.");
        }

        public override void OpenFile()
        {
            Console.WriteLine("Opening CSV file...");
        }

        public override void ProcessFile()
        {
            Console.WriteLine("Processing CSV file content...");
        }
    }
}
