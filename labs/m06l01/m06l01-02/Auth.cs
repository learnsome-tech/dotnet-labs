// Modern .NET Core, C# & Enterprise Microservices — lesson m06l01 — Authentication: JWTs and Claims
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m06l01
// © LearnSome.tech
builder.Services.AddAuthentication().AddJwtBearer(options =>
{
    options.Authority = configuration["Auth:Authority"];
    options.Audience = "catalog-api";
});
builder.Services.AddAuthorization();
