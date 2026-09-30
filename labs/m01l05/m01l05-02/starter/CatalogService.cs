using System.Net.Http.Json;

public sealed class CatalogService(HttpClient http)
{
    public async Task<Product?> GetProductAsync(int id, CancellationToken ct)
    {
        var response = await http.GetAsync($"products/{id}", ct);
        if (!response.IsSuccessStatusCode) return null;
        return await response.Content.ReadFromJsonAsync<Product>(ct);
    }
}

public sealed record Product(int Id, string Name, decimal Price);
