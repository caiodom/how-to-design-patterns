using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class FileProcessor
    {
        public void Template()
        {
            OpenFile();
            ProcessFile();
            CloseFile();
        }


        public abstract void OpenFile();
        public abstract void ProcessFile();
        public abstract void CloseFile();    

    }
}
