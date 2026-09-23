// Modern .NET Core, C# & Enterprise Microservices — lesson m02l05 — The Options Pattern: Strongly Typed Configuration
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m02l05
// © LearnSome.tech
    public static IHostApplicationBuilder AddCatalogPlatform(
        this IHostApplicationBuilder builder)
    {
        IServiceCollection services = builder.Services;

        services.AddOptions<CatalogOptions>()
            .BindConfiguration(CatalogOptions.SectionName)
            .ValidateDataAnnotations()
            .ValidateOnStart();
