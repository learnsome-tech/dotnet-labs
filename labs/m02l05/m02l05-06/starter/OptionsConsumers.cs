using Microsoft.Extensions.Options;

// Singleton: bound once, at first use, and never recomputed.
public sealed class TokenIssuer(IOptions<CatalogOptions> options)
{
    private CatalogOptions Settings { get; } = options.Value;
}

// Scoped: recomputed per scope, so an edit lands next request.
public sealed class PricingService(IOptionsSnapshot<CatalogOptions> opt)
{
    private CatalogOptions Settings => opt.Value;
}

// A singleton that must notice a reload: CurrentValue and OnChange.
public sealed class PriceCache(IOptionsMonitor<CatalogOptions> monitor)
{
    public string Currency => monitor.CurrentValue.DefaultCurrency;

    public IDisposable? OnReload(Action<CatalogOptions> handler) =>
        monitor.OnChange(handler);
}
