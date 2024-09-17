using Adapter.Interfaces;

namespace Adapter.Services
{
    public class PayPalService: IPayPalService
    {
        public void MakePayPalPayment(double total)
        {
            if (total <= 0)
                throw new ArgumentException("Payment amount must be positive.");

            Console.WriteLine($"PayPal payment of {total} processed.");
        }
    }
}
