// Modern .NET Core, C# & Enterprise Microservices — lesson m05l01 — Model Validation and FluentValidation
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m05l01
// © LearnSome.tech
var result = validator.Validate(new CreateProductRequest("", 0));
foreach (var error in result.Errors) Console.WriteLine(error.PropertyName);
