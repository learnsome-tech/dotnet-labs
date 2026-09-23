// Modern .NET Core, C# & Enterprise Microservices — lesson m02l04 — The Dependency Injection Container: Scopes and Lifetimes
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m02l04
// © LearnSome.tech
builder.Services.AddTransient<IClock, SystemClock>();
builder.Services.AddScoped<IOrderReader, OrderReader>();
builder.Services.AddSingleton<ITenantCatalog, TenantCatalog>();
