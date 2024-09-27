
namespace Visitor
{
    // Concrete class for Revenue Report
    public class RevenueReport : IReport
    {
        public double Revenue { get; set; }

        public RevenueReport(double revenue)
        {
            Revenue = revenue;
        }

        // Implementation of the Accept method, allowing visitors to operate on this report
        public void Accept(IReportVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
