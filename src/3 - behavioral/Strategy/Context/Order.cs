
using Strategy;

namespace Strategy
{
    public class Order
    {
        private IPaymentStrategy _paymentStrategy;

        public Order(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }
        public void ProcessOrderPayment(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }



    }
}
