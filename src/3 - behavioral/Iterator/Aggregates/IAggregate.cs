using Iterator.IteratorInterfaces;

namespace Iterator.Aggregates
{
    // Interface Aggregate
    public interface IAggregate
    {
        IIterator CreateNormalIterator();
        IIterator CreateReverseIterator();
    }
}
