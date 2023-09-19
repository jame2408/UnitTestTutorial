using StockRoiCalculator.Models;

namespace StockRoiCalculator.Repositories;

public class StockRepository
{
    /// <summary>
    /// Retrieves Taiwan stock information based on the ETF code from the database.
    /// </summary>
    /// <param name="code">The ETF code.</param>
    /// <returns>A list of Taiwan stocks that match the specified ETF code.</returns>
    public async Task<IEnumerable<Stock>> GetTaiwanStocksByEtfAsync(string code)
    {
        throw new NotImplementedException();
    }
}