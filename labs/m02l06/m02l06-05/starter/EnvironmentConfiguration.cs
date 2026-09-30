var builder = WebApplication.CreateBuilder(args);

var signingKey = builder.Configuration["Catalog:SigningKey"];
Console.WriteLine(signingKey is null ? "missing" : "configured");
