// Modern .NET Core, C# & Enterprise Microservices — lesson m05l02 — Global Exception Handling and Problem Details
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m05l02
// © LearnSome.tech
builder.Services.AddProblemDetails();

var app = builder.Build();
app.UseExceptionHandler();
app.UseStatusCodePages();
