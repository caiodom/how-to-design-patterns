using Adapter.Interfaces;


namespace Adapter
{
    public class BasicPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Basic payment of {amount} processed.");

        }
    }
}
