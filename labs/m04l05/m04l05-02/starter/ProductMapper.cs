[Mapper]
public partial class ProductMapper
{
    public partial ProductResponse ToResponse(Product product);
    public partial Product ToEntity(CreateProductRequest request);
}
