// Modern .NET Core, C# & Enterprise Microservices — lesson m05l04 — API Documentation UI with Scalar
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m05l04
// © LearnSome.tech
builder.Services.AddOpenApi();

var app = builder.Build();
app.MapOpenApi();
app.MapScalarApiReference();
