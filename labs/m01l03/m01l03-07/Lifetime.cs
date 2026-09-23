// Modern .NET Core, C# & Enterprise Microservices — lesson m01l03 — Classes, Interfaces, and Object-Oriented C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l03
// © LearnSome.tech
Console.WriteLine("work starting");
using var work = new UnitOfWork("orders");
work.Save();
Console.WriteLine("work finished");

sealed class UnitOfWork(string name) : IDisposable
{
    public void Save() => Console.WriteLine($"saving {name}");

    public void Dispose() => Console.WriteLine($"disposing {name}");
}
