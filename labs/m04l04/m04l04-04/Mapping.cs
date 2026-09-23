// Modern .NET Core, C# & Enterprise Microservices — lesson m04l04 — Manual Object Mapping
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m04l04
// © LearnSome.tech
var entity = new Product { Id = 7, Name = "Kettle", Price = 24.99m };
var response = entity.ToResponse();
Console.WriteLine($"{response.Id}: {response.Name}");
