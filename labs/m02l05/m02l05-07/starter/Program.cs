using Catalog.Application;

var builder = WebApplication.CreateBuilder(args);

// appsettings.json now says "MaxPageSize": 5000.
builder.Services.AddOptions<CatalogOptions>()
    .BindConfiguration(CatalogOptions.SectionName)
    .ValidateDataAnnotations()
    .ValidateOnStart();

var app = builder.Build();
app.MapGet("/products", () => "never reached");
app.Run();
