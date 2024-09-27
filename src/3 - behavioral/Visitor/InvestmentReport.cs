
namespace Visitor
{
    // Concrete class for Investment Report
    public class InvestmentReport : IReport
    {
        public double Investments { get; set; }

        public InvestmentReport(double investments)
        {
            Investments = investments;
        }

        // Implementation of the Accept method, allowing visitors to operate on this report
        public void Accept(IReportVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
