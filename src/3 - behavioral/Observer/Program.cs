using Observer.Observers;
using Observer.Subject;
using Observer.Utils;

StockMarket stockMarket = new StockMarket();

Investor investorJohn = new Investor("John");
investorJohn.SetPriceLimit(StockSymbol.AAPL, 50);

Investor investorMary = new Investor("Mary");
investorMary.SetPriceLimit(StockSymbol.GOOG, 100);

stockMarket.RegisterObserver(investorJohn, StockSymbol.AAPL);
stockMarket.RegisterObserver(investorMary, StockSymbol.GOOG);

// Simulate price changes
stockMarket.SetStockPrice(StockSymbol.AAPL, 55); 
stockMarket.SetStockPrice(StockSymbol.GOOG, 95); 
stockMarket.SetStockPrice(StockSymbol.AAPL, 45); 