namespace Catalog.Pricing;

public sealed class Cart
{
    private readonly List<string> _codes = [];
    private readonly Dictionary<string, decimal> _prices = new();
    private string? _currency;

    public void Add(string code, decimal price)
    {
        if (price < 0) throw new ArgumentOutOfRangeException(nameof(price));
        _currency ??= "GBP";
        _codes.Add(code);
        _prices[code] = price;
    }
}
