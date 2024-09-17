using Adapter.Interfaces;

namespace Adapter.Adapters
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly IPayPalService _payPalService;
        public PayPalAdapter(IPayPalService payPalService)
        {
            _payPalService = payPalService;
        }

        public void ProcessPayment(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Payment amount must be positive.");

            _payPalService.MakePayPalPayment(Convert.ToDouble(amount));
        }
    }
}
