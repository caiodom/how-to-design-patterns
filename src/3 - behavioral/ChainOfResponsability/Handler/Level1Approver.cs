
namespace ChainOfResponsability.Handler
{
    //Concrete Handler
    public class Level1Approver : Handler
    {
        public override void HandleRequest(RefundRequest request)
        {
            if (request is null)
                throw new ArgumentException("Refund request cannot be null");

            if (request.RefundAmount <= 1000.00M)
                Console.WriteLine("Approved by Level 1 team");
            else if (next != null)
            {
                Console.WriteLine("Level 1 team forwarded the request");
                next.HandleRequest(request);
            }
                

        }
    }
}
