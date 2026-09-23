// Modern .NET Core, C# & Enterprise Microservices — lesson m02l03 — Code Quality: .editorconfig and Roslyn Analyzers
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m02l03
// © LearnSome.tech
using var stream = File.OpenRead("missing.txt");
Console.WriteLine(stream.Length);
