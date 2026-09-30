public async Task AddAsync(Product product, CancellationToken token)
{
    await db.Products.AddAsync(product, token);
    await db.SaveChangesAsync(token);
    Console.WriteLine("saved");
}
