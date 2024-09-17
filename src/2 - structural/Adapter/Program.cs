// See https://aka.ms/new-console-template for more information
using Adapter;
using Adapter.Adapters;
using Adapter.Interfaces;
using Adapter.Services;


try
{
    Console.WriteLine("-----Adapter example-------");
    var paymentProcessors = new List<IPaymentProcessor>
        {
            new BasicPaymentProcessor(),
            new PayPalAdapter(new PayPalService()),
            new CryptoAdapter(new CryptoPaymentService())
        };

    foreach (var processor in paymentProcessors)
        processor.ProcessPayment(5069.45M);
}
catch (Exception ex)
{
    Console.WriteLine($"Error processing payment: {ex.Message}");
}

Console.ReadKey();