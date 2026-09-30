using System.Text;

var sku = "wid-7";
var upper = sku.ToUpperInvariant();
Console.WriteLine($"{sku} -> {upper}");

var json = """
    { "sku": "wid-7", "price": 19.90 }
    """;
Console.WriteLine(json);

var sb = new StringBuilder();
for (var i = 1; i <= 3; i++) sb.Append(i).Append(';');
Console.WriteLine(sb.ToString());
