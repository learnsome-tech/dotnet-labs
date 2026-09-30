var product = await db.Products
    .AsNoTracking()
    .Where(p => p.Id == id)
    .Select(p => new ProductResponse(p.Id, p.Name, p.Price))
    .SingleOrDefaultAsync();

var tracked = await db.Products.SingleAsync(p => p.Id == id);
tracked.Price = newPrice;
await db.SaveChangesAsync();
