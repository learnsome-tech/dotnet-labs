// Modern .NET Core, C# & Enterprise Microservices — lesson m07l04 — OpenTelemetry, Container Publishing and Trimming
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m07l04
// © LearnSome.tech
builder.Services.AddOpenTelemetry()
    .WithTracing(tracing => tracing
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation())
    .WithMetrics(metrics => metrics
        .AddAspNetCoreInstrumentation());
