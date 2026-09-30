namespace Catalog.Contracts;

public record CreateProductRequest(string Name, decimal Price);

public record ProductResponse(int Id, string Name, decimal Price);

public readonly record struct Money(decimal Amount, string Currency);
