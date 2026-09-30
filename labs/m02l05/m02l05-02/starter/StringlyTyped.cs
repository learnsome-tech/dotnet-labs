using Microsoft.Extensions.Configuration;

public sealed class PagingDefaults(IConfiguration config)
{
    // A key that does not exist is a null, not an error.
    public string Currency => config["Catalog:DefaultCurency"]!;

    // Parsed by hand, at every call site, with nowhere to say
    // what a good value would have been.
    public int PageSize => int.Parse(config["Catalog:DefaultPageSize"]!);

    // A maximum that the default is supposed to respect.
    public int MaxPageSize => int.Parse(config["Catalog:MaxPageSize"]!);
}
