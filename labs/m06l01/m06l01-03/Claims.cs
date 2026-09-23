// Modern .NET Core, C# & Enterprise Microservices — lesson m06l01 — Authentication: JWTs and Claims
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m06l01
// © LearnSome.tech
var user = new ClaimsPrincipal(new ClaimsIdentity("Bearer"));
Console.WriteLine(user.Identity?.IsAuthenticated == true);
