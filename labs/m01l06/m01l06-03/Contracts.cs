// Modern .NET Core, C# & Enterprise Microservices — lesson m01l06 — Records, Pattern Matching, and Modern C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l06
// © LearnSome.tech
namespace Catalog.Contracts;

public record CreateProductRequest(string Name, decimal Price);

public record ProductResponse(int Id, string Name, decimal Price);

public readonly record struct Money(decimal Amount, string Currency);
