namespace Visitor
{
    // Concrete class for Expense Report
    public class ExpenseReport : IReport
    {
        public double Expenses { get; set; }

        public ExpenseReport(double expenses)
        {
            Expenses = expenses;
        }

        // Implementation of the Accept method, allowing visitors to operate on this report
        public void Accept(IReportVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
