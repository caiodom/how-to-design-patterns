
namespace Visitor
{
    // Concrete visitor that exports reports to PDF
    public class PdfExportVisitor : IReportVisitor
    {
        public void Visit(RevenueReport revenueReport)
        {
            // Simulates exporting the revenue report to PDF
            Console.WriteLine($"Exporting Revenue Report with Revenue: {revenueReport.Revenue} to PDF.");
        }

        public void Visit(ExpenseReport expenseReport)
        {
            // Simulates exporting the expense report to PDF
            Console.WriteLine($"Exporting Expense Report with Expenses: {expenseReport.Expenses} to PDF.");
        }

        public void Visit(InvestmentReport investmentReport)
        {
            // Simulates exporting the investment report to PDF
            Console.WriteLine($"Exporting Investment Report with Investments: {investmentReport.Investments} to PDF.");
        }
    }
}
