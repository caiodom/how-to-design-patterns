using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    //Subject
    public interface IDatabaseAccess
    {
        void RequestData(string userName);
    }
}
