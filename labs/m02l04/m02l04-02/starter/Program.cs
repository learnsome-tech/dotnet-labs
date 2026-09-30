builder.Services.AddTransient<IClock, SystemClock>();
builder.Services.AddScoped<IOrderReader, OrderReader>();
builder.Services.AddSingleton<ITenantCatalog, TenantCatalog>();
