// Modern .NET Core, C# & Enterprise Microservices — lesson m06l05 — Retry and Circuit Breaker Policies with Polly
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m06l05
// © LearnSome.tech
builder.Services.AddHttpClient<IInventoryClient, InventoryClient>()
    .AddStandardResilienceHandler(options =>
    {
        options.Retry.MaxRetryAttempts = 3;
        options.TotalRequestTimeout.Timeout = TimeSpan.FromSeconds(5);
    });
