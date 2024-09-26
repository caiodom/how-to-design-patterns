using State.Context;
using State.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class ReadyForDeliveryState : IOrderState
    {
        private readonly Order _order;
        public ReadyForDeliveryState(Order order)
        {
            _order= order;
        }

        public void Cancel(Order order)
        {
            Console.WriteLine("Cannot cancel. Order is ready for delivery.");
        }

        public OrderStatus GetStatus()
        {
            return OrderStatus.READY_FOR_DELIVERY;
        }

        public void Proceed(Order order)
        {
            order.SetState(order._deliveredState);
            Console.WriteLine("Order has been delivered.");
        }
    }
}
