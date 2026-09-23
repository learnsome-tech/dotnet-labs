// Modern .NET Core, C# & Enterprise Microservices — lesson m01l01 — What is .NET? Runtime vs SDK, and LTS vs STS
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l01
// © LearnSome.tech
// Top level statements: no class, no Main - the compiler adds them
Console.WriteLine("Hello, World!");

var target = "net10.0";
var isLts = true;
Console.WriteLine($"Target framework: {target}");
Console.WriteLine($"Long term support: {isLts}");
