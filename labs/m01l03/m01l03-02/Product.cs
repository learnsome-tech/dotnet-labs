// Modern .NET Core, C# & Enterprise Microservices — lesson m01l03 — Classes, Interfaces, and Object-Oriented C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l03
// © LearnSome.tech
public class Product
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public Guid Id { get; init; } = Guid.NewGuid();
    public int Units { get; private set; }

    public bool InStock => Units > 0;

    public void Receive(int units) => Units += units;
}
