// Modern .NET Core, C# & Enterprise Microservices — lesson m03l01 — The ASP.NET Core Middleware Pipeline
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m03l01
// © LearnSome.tech
app.UseExceptionHandler();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
