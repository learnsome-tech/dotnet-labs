// Modern .NET Core, C# & Enterprise Microservices — lesson m03l03 — Building Routes with Minimal APIs
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m03l03
// © LearnSome.tech
app.MapGet("/api/ping", () => Results.Ok("catalog"));
app.Run();
