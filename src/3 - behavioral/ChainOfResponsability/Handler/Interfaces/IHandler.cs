using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handler.Interfaces
{
    public interface IHandler
    {

        void SetNext(IHandler handler);

        void HandleRequest(RefundRequest request);
    }
}
