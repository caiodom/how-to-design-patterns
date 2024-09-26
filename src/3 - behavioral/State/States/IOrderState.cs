using State.Context;
using State.Utils;

namespace State.States
{
    public interface IOrderState
    {

        void Proceed(Order order);
        void Cancel(Order order);
        OrderStatus GetStatus();

    }
}
