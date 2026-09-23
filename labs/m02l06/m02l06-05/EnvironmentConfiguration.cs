// Modern .NET Core, C# & Enterprise Microservices — lesson m02l06 — Environment Layering and User Secrets
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m02l06
// © LearnSome.tech
var builder = WebApplication.CreateBuilder(args);

var signingKey = builder.Configuration["Catalog:SigningKey"];
Console.WriteLine(signingKey is null ? "missing" : "configured");
