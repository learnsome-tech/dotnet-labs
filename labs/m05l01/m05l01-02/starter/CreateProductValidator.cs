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
