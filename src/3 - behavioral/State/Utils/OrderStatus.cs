using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Utils
{
    public enum OrderStatus
    {
        NEW_ORDER,
        BEIGN_PREPARED,
        READY_FOR_DELIVERY,
        DELIVERED,
        CANCELED
    }
}
