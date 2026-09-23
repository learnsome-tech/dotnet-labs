// Modern .NET Core, C# & Enterprise Microservices — lesson m04l05 — Source-Generated Mapping with Mapperly
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m04l05
// © LearnSome.tech
[Mapper]
public partial class ProductMapper
{
    public partial ProductResponse ToResponse(Product product);
    public partial Product ToEntity(CreateProductRequest request);
}
