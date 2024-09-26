using State.Context;
using State.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class CanceledState : IOrderState
    {
        private readonly Order _order;
        public CanceledState(Order order)
        {
            _order = order;
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Order is already canceled.");
        }

        public OrderStatus GetStatus()
        {
            return OrderStatus.CANCELED;
        }

        public void Proceed(Order order)
        {
            Console.WriteLine("Order has been canceled. Cannot proceed.");
        }
    }
}
