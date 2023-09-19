namespace StockRoiCalculator.Models.Comparer;

public class StockComparer : IEqualityComparer<Stock>
{
    public bool Equals(Stock? x, Stock? y)
    {
        if (x == null || y == null)
        {
            return false;
        }

        return x.Code == y.Code;
    }

    public int GetHashCode(Stock obj)
    {
        return obj.Code.GetHashCode();
    }
}