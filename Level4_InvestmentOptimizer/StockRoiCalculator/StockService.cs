using StockRoiCalculator.Models;
using StockRoiCalculator.Models.Comparer;
using StockRoiCalculator.Repositories;

namespace StockRoiCalculator;

public class StockService
{
    public async Task<IEnumerable<StockWithRoi>> CalculateTaiwanStocksRoiAsync()
    {
        var stockRepository = new StockRepository();
        
        // Get taiwan stocks by ETF, e.g. 0050, 0056
        var stocks50 = await stockRepository.GetTaiwanStocksByEtfAsync("0050");
        var stocks56 = await stockRepository.GetTaiwanStocksByEtfAsync("0056");
        
        // Get common stocks from 0050 and 0056
        var commonStocks = stocks50.Intersect(stocks56, new StockComparer()).ToList();
        if (commonStocks.Any() == false)
        {
            // TODO: write log
            return Enumerable.Empty<StockWithRoi>();
        }

        // Calculate ROI of common stocks
        var sortedStocks = commonStocks
            .Select(stock => new StockWithRoi
            {
                Stock = stock,
                Roi = (stock.CurrentPrice - stock.InitialPrice) / stock.InitialPrice
            })
            .OrderByDescending(x => x.Roi);

        return sortedStocks;
    }
}