// Modern .NET Core, C# & Enterprise Microservices — lesson m06l04 — Health Checks
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m06l04
// © LearnSome.tech
builder.Services.AddHealthChecks();

var app = builder.Build();
app.MapHealthChecks("/health/live");
app.MapHealthChecks("/health/ready");
