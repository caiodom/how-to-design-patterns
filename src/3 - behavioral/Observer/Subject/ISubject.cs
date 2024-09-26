
using Observer.Observers;
using Observer.Utils;

namespace Observer.Subject
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer, StockSymbol stockSymbol);
        void RemoveObserver(IObserver observer, StockSymbol stockSymbol);
        void NotifyObservers(StockSymbol stockSymbol);
    }
}
