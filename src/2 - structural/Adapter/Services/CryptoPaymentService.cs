using Adapter.Interfaces;

namespace Adapter.Services
{
    public class CryptoPaymentService: ICryptoPaymentService
    {
        public void PayWithCrypto(float value)
        {
            if (value <= 0)
                throw new ArgumentException("Payment amount must be positive.");

            Console.WriteLine($"Cryptocurrency payment of {value} processed.");
        }
    }
}
