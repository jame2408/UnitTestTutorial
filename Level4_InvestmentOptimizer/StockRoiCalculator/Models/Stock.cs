namespace StockRoiCalculator.Models;

public class Stock
{
    public string Code { get; }
    public decimal InitialPrice { get; }
    public decimal CurrentPrice { get; }

    public Stock(string code, decimal initialPrice, decimal currentPrice)
    {
        Code = code;
        InitialPrice = initialPrice;
        CurrentPrice = currentPrice;
    }
}