
using Observer.Utils;

namespace Observer.Observers
{
    public interface IObserver
    {

        decimal GetPriceLimit(StockSymbol stockSymbol, decimal limit);
        string GetName();
        void Update(StockSymbol stockSymbol,decimal price);


    }
}
