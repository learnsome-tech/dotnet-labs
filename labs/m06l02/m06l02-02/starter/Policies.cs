builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("catalog.write", policy =>
        policy.RequireClaim("scope", "catalog.write"));
});

app.MapPost("/api/products", Create).RequireAuthorization("catalog.write");
