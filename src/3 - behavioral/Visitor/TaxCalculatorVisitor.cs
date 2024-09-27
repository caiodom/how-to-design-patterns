
namespace Visitor
{
    // Concrete visitor that calculates tax for each report
    public class TaxCalculatorVisitor : IReportVisitor
    {
        public void Visit(RevenueReport revenueReport)
        {
            // Simulates tax calculation based on revenue
            double tax = revenueReport.Revenue * 0.15;
            Console.WriteLine($"Tax on Revenue Report: {tax}");
        }

        public void Visit(ExpenseReport expenseReport)
        {
            // Simulates tax reduction based on expenses
            double taxReduction = expenseReport.Expenses * 0.05;
            Console.WriteLine($"Tax reduction on Expense Report: {taxReduction}");
        }

        public void Visit(InvestmentReport investmentReport)
        {
            // Simulates tax on investments
            double tax = investmentReport.Investments * 0.1;
            Console.WriteLine($"Tax on Investment Report: {tax}");
        }
    }
}
