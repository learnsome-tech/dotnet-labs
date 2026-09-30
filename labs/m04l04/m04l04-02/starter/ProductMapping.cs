public static ProductResponse ToResponse(this Product product)
    => new(
        product.Id,
        product.Name,
        product.Price);

public static Product ToEntity(this CreateProductRequest request)
    => new()
    {
        Name = request.Name,
        Price = request.Price
    };
