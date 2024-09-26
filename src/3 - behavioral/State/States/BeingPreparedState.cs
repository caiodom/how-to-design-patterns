using State.Context;
using State.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class BeingPreparedState : IOrderState
    {
        private readonly Order _order;
        public BeingPreparedState(Order order)
        {
            _order=order;
        }

        public void Cancel(Order order)
        {
            order.SetState(order._canceledState);
            Console.WriteLine("Order has been canceled.");
        }

        public OrderStatus GetStatus()
        {
            return OrderStatus.BEIGN_PREPARED;
        }

        public void Proceed(Order order)
        {
            Console.WriteLine("Order is ready for delivery.");
            order.SetState(_order._readyForDeliveryState);
        }
    }
}
