using Observer.Observers;
using Observer.Utils;

namespace Observer.Subject
{
    public class StockMarket : ISubject
    {
        private readonly Dictionary<StockSymbol, List<IObserver>> _stockObservers;
        private readonly Dictionary<StockSymbol, decimal> _stockPrices;
        public StockMarket()
        {
            _stockObservers = new Dictionary<StockSymbol, List<IObserver>>();
            _stockPrices = new Dictionary<StockSymbol, decimal>();
        }

        public void NotifyObservers(StockSymbol stockSymbol)
        {
            if (_stockObservers.ContainsKey(stockSymbol))
            {
                decimal price = _stockPrices[stockSymbol];
                foreach (var observer in _stockObservers[stockSymbol])
                {
                    observer.Update(stockSymbol, price);
                }
            }

        }

        public void RegisterObserver(IObserver observer, StockSymbol stockSymbol)
        {
            if (!_stockObservers.ContainsKey(stockSymbol))
                _stockObservers[stockSymbol] = new List<IObserver>();

            _stockObservers[stockSymbol].Add(observer);
        }

        public void RemoveObserver(IObserver observer, StockSymbol stockSymbol)
        {
            if (_stockObservers.ContainsKey(stockSymbol))
                _stockObservers[stockSymbol].Remove(observer);
        }

        public void SetStockPrice(StockSymbol stockSymbol, decimal price)
        {
            _stockPrices[stockSymbol] = price;
            NotifyObservers(stockSymbol);
        }


    }
}
