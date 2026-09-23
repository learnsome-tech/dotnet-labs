// Modern .NET Core, C# & Enterprise Microservices — lesson m01l02 — The C# Language: Types, Variables, and Flow Control
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l02
// © LearnSome.tech
int quantity = 12;
long productId = 9_000_000_000;
var unitPrice = 4.5;
var sku = "wid-7";

Console.WriteLine(quantity.GetType());
Console.WriteLine(productId.GetType());
Console.WriteLine(unitPrice.GetType());
Console.WriteLine(sku.GetType());

// sku = 7; would not compile: var chose string and kept it.
