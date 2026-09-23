// Modern .NET Core, C# & Enterprise Microservices — lesson m01l04 — Collections, Generics, and LINQ
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l04
// © LearnSome.tech
List<Product> items =
[
    new("Kettle", "Kitchen", 24.50m),
    new("Lamp", "Home", 12.00m),
    new("Mug", "Kitchen", 6.25m),
];

Console.WriteLine(items.Any(p => p.Price > 20m));
Console.WriteLine(items.Count(p => p.Category == "Kitchen"));
Console.WriteLine(items.Sum(p => p.Price));

foreach (var g in items.GroupBy(p => p.Category))
    Console.WriteLine($"{g.Key} has {g.Count()}");

record Product(string Name, string Category, decimal Price);
