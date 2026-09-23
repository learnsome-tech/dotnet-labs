// Modern .NET Core, C# & Enterprise Microservices — lesson m01l06 — Records, Pattern Matching, and Modern C#
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l06
// © LearnSome.tech
var kettle = new Product(1, "Kettle");
var same = new Product(1, "Kettle");
var renamed = kettle with { Name = "Teapot" };

Console.WriteLine(kettle);
Console.WriteLine(kettle == same);
Console.WriteLine(object.ReferenceEquals(kettle, same));
Console.WriteLine(renamed);

public record Product(int Id, string Name);
