// Modern .NET Core, C# & Enterprise Microservices — lesson m03l01 — The ASP.NET Core Middleware Pipeline
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m03l01
// © LearnSome.tech
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(async (context, next) =>
{
    Console.WriteLine(context.Request.Path);
    await next();
});
app.MapGet("/health", () => Results.Ok("up"));
app.Run();
