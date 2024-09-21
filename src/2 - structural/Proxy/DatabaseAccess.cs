using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    //RealSubject
    public class DatabaseAccess : IDatabaseAccess
    {
        public void RequestData(string userName)
        {
            Console.WriteLine($"Access granted. {userName} is retrieving sensitive data from the database.");
        }
    }
}
