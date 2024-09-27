
namespace Visitor
{
    // Visitor interface that declares operations for each type of report
    public interface IReportVisitor
    {
        void Visit(RevenueReport revenueReport);
        void Visit(ExpenseReport expenseReport);
        void Visit(InvestmentReport investmentReport);
    }
}
