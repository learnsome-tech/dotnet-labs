// Modern .NET Core, C# & Enterprise Microservices — lesson m06l03 — Built-in Rate Limiting Middleware
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m06l03
// © LearnSome.tech
builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("catalog", limiter =>
    {
        limiter.PermitLimit = 100;
        limiter.Window = TimeSpan.FromMinutes(1);
    });
});
app.UseRateLimiter();
