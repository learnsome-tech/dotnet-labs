public interface IProductRepository
{
    Product? Get(Guid id);
    void Save(Product product);
    IReadOnlyList<Product> All();

    bool Exists(Guid id) => Get(id) is not null;
}

// Module two registers the contract, not the class:
// builder.Services.AddScoped<IProductRepository, SqlProductRepository>();
