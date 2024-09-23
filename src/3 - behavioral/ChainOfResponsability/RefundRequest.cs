using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class RefundRequest
    {
        public decimal RefundAmount { get; set; }

        public RefundRequest(decimal refundAmount)
        {
            RefundAmount = refundAmount;
        }

    }
}
