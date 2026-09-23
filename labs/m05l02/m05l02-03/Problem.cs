// Modern .NET Core, C# & Enterprise Microservices — lesson m05l02 — Global Exception Handling and Problem Details
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m05l02
// © LearnSome.tech
var problem = Results.Conflict(new { title = "Product already exists" });
Console.WriteLine(409);
Console.WriteLine("Product already exists");
