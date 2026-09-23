// Modern .NET Core, C# & Enterprise Microservices — lesson m06l02 — Role-Based and Policy-Based Authorization
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m06l02
// © LearnSome.tech
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("catalog.write", policy =>
        policy.RequireClaim("scope", "catalog.write"));
});

app.MapPost("/api/products", Create).RequireAuthorization("catalog.write");
