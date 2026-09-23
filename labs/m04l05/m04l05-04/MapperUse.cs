// Modern .NET Core, C# & Enterprise Microservices — lesson m04l05 — Source-Generated Mapping with Mapperly
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m04l05
// © LearnSome.tech
var mapper = new ProductMapper();
var response = mapper.ToResponse(product);
Console.WriteLine(response.Name);
