builder.Services.AddAuthentication().AddJwtBearer(options =>
{
    options.Authority = configuration["Auth:Authority"];
    options.Audience = "catalog-api";
});
builder.Services.AddAuthorization();
