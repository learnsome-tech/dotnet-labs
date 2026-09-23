// Modern .NET Core, C# & Enterprise Microservices — lesson m01l06 — Records, Pattern Matching, and Modern C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l06
// © LearnSome.tech
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
