
namespace Visitor
{
    // Interface IReport that declares the Accept method
    public interface IReport
    {
        // Method to accept a visitor
        void Accept(IReportVisitor visitor);
    }
}
