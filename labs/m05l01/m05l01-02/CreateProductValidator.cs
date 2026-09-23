// Modern .NET Core, C# & Enterprise Microservices — lesson m05l01 — Model Validation and FluentValidation
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m05l01
// © LearnSome.tech
public sealed record CreateProductRequest(string Name, decimal Price);

public sealed class CreateProductValidator
    : AbstractValidator<CreateProductRequest>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(120);
        RuleFor(x => x.Price).GreaterThan(0);
    }
}
