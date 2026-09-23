// Modern .NET Core, C# & Enterprise Microservices — lesson m01l02 — The C# Language: Types, Variables, and Flow Control
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l02
// © LearnSome.tech
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
