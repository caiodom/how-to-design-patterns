using Adapter.Interfaces;

namespace Adapter.Adapters
{
    public class CryptoAdapter : IPaymentProcessor
    {
        private readonly ICryptoPaymentService _cryptoPaymentService;
        public CryptoAdapter(ICryptoPaymentService cryptoPaymentService)
        {
            _cryptoPaymentService = cryptoPaymentService;
        }

        public void ProcessPayment(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Payment amount must be positive.");

            _cryptoPaymentService.PayWithCrypto((float) amount);
        }
    }
}
