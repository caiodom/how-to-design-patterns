
using State.Context;
using State.Utils;

namespace State.States
{
    public class NewOrderState : IOrderState
    {
        private readonly Order _order;


        public NewOrderState(Order order)
        {
            _order=order;
        }

        public void Cancel(Order order)
        {

             if(order.GetStatus()!= OrderStatus.CANCELED)
                order.SetState(order._canceledState);

            Console.WriteLine("Order has been canceled.");

        }


        public OrderStatus GetStatus()
        {
            return OrderStatus.NEW_ORDER;
        }

        public void Proceed(Order order)
        {
            Console.WriteLine("Order is being prepared.");
            order.SetState(order._beingPreparedState);
        }
    }
}
