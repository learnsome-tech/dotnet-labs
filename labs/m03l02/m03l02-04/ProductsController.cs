// Modern .NET Core, C# & Enterprise Microservices — lesson m03l02 — Building Routes with Controllers
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m03l02
// © LearnSome.tech
[HttpGet]
public ActionResult<string> Ping() => Ok("catalog");
