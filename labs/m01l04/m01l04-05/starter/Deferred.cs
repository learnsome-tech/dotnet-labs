int[] prices = [12, 40, 7, 95];

IEnumerable<int> big = prices.Where(p =>
{
    Console.WriteLine($"testing {p}");
    return p > 10;
});

Console.WriteLine("query built");

foreach (int p in big)
{
    Console.WriteLine($"kept {p}");
}
