using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;
        public FileLogger(string filePath)
        {
           _filePath=filePath;
        }




        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
