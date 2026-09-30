    public static IHostApplicationBuilder AddCatalogPlatform(
        this IHostApplicationBuilder builder)
    {
        IServiceCollection services = builder.Services;

        services.AddOptions<CatalogOptions>()
            .BindConfiguration(CatalogOptions.SectionName)
            .ValidateDataAnnotations()
            .ValidateOnStart();
