// Modern .NET Core, C# & Enterprise Microservices — lesson m05l03 — OpenAPI Generation in .NET 9
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m05l03
// © LearnSome.tech
builder.Services.AddOpenApi();

var app = builder.Build();
app.MapOpenApi();
