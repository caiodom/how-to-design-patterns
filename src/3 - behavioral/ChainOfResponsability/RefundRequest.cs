
namespace ChainOfResponsability
{
    public class RefundRequest
    {
        public decimal RefundAmount { get; set; }

        public RefundRequest(decimal refundAmount)
        {
            RefundAmount = refundAmount;
        }

    }
}
