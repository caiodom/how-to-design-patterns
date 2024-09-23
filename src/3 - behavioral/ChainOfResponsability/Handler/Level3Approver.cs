
namespace ChainOfResponsability.Handler
{
    public class Level3Approver : Handler
    {
        public override void HandleRequest(RefundRequest request)
        {
            if (request == null)
                throw new ArgumentException("Refund request cannot be null");

            if(request.RefundAmount > 5000)
                Console.WriteLine("Approved by Level 3 team");
            else
                Console.WriteLine("Request is too complex to handle.");


        }
    }
}
