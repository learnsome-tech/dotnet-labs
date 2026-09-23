// Modern .NET Core, C# & Enterprise Microservices — lesson m04l02 — Querying, Change Tracking, and Saving Data
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m04l02
// © LearnSome.tech
var names = new[] { "Kettle", "Mug" }
    .Where(name => name.Length > 3)
    .Select(name => name.ToUpperInvariant());
foreach (var name in names) Console.WriteLine(name);
