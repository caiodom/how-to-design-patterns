

namespace ChainOfResponsability.Handler
{
    public class Level2Approver : Handler
    {
        public override void HandleRequest(RefundRequest request)
        {

            if (request is null)
                throw new ArgumentException("Refund request cannot be null");

            if (request.RefundAmount <= 5000.00M)
                Console.WriteLine("Approved by Level 2 team");
            else if (next != null)
            {
                Console.WriteLine("Level 2 team forwarded the request");
                next.HandleRequest(request);
            }
                

        }
    }
}
