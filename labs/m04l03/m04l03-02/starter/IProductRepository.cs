public interface IProductRepository
{
    Task<Product?> FindAsync(int id, CancellationToken cancellationToken);
    Task<IReadOnlyList<Product>> SearchAsync
        string term, CancellationToken cancellationToken);
    Task AddAsync(Product product, CancellationToken cancellationToken);
}
