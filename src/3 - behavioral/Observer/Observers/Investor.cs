

using Observer.Utils;

namespace Observer.Observers
{
    public class Investor : IObserver
    {
        private readonly string _name;
        private readonly Dictionary<StockSymbol, decimal> _stockPriceLimits;

        public Investor(string name)
        {
            _name = name;
            _stockPriceLimits = new Dictionary<StockSymbol, decimal>();

        }

        public void Update(StockSymbol stockSymbol,decimal price)
        {
            Console.WriteLine($"{_name} was notified: The price of {stockSymbol} is now ${price}");

            if(_stockPriceLimits.ContainsKey(stockSymbol) && price <_stockPriceLimits[stockSymbol])
                Console.WriteLine($"{_name}: SELL ALERT! The price of {stockSymbol} fell below ${_stockPriceLimits[stockSymbol]}");
        }

        public void SetPriceLimit(StockSymbol stockTypes,decimal limit)
        {
            _stockPriceLimits[stockTypes] = limit;
        }

        public decimal GetPriceLimit(StockSymbol stockSymbol, decimal limit)
        {
            return _stockPriceLimits.ContainsKey(stockSymbol) ? _stockPriceLimits[stockSymbol] : decimal.MaxValue;
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
