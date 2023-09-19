namespace StockRoiCalculator.Models;

public class StockWithRoi
{
    public Stock Stock { get; init; } = null!;
    public decimal Roi { get; init; }
}