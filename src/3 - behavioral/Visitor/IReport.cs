
namespace Visitor
{
    public interface IReport
    {
        // Method to accept a visitor
        void Accept(IReportVisitor visitor);
    }
}
