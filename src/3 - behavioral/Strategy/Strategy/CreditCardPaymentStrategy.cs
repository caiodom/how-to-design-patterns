
namespace Strategy
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount:C}");
        }
    }
}
