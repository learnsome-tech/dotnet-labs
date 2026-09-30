string[] tags = ["sale", "new", "sale"];
List<string> names = ["Kettle", "Lamp", "Mug"];
Dictionary<string, decimal> prices = new()
{
    ["Kettle"] = 24.50m,
    ["Lamp"] = 12.00m,
};
HashSet<string> unique = [.. tags];

Console.WriteLine(names.Count);
Console.WriteLine(names[1]);
Console.WriteLine(prices["Kettle"]);
Console.WriteLine(prices.ContainsKey("Mug"));
Console.WriteLine(unique.Count);
Console.WriteLine(unique.Contains("new"));
