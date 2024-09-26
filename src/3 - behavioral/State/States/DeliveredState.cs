using State.Context;
using State.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class DeliveredState : IOrderState
    {
        private readonly Order _order;
        public DeliveredState(Order order)
        {
            _order = order;
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Cannot cancel. Order has already been delivered.");
        }

        public OrderStatus GetStatus()
        {
            return OrderStatus.DELIVERED;
        }

        public void Proceed(Order order)
        {
            Console.WriteLine("Order has already been delivered.");
        }
    }
}
