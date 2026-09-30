int[] orders = [3, 0, 1];
var total = 0;
for (var i = 0; i < orders.Length; i++) total += orders[i];
foreach (var qty in orders) Console.Write($"{qty};");
Console.WriteLine();
var left = total;
while (left > 0) left--;
Console.WriteLine($"total {total}, left {left}");
Console.WriteLine(Price("wid-7"));
Console.WriteLine(Price(""));

static string Price(string? sku)
{
    if (sku is null || sku.Length == 0) return "unknown";
    return $"price of {sku}";
}
