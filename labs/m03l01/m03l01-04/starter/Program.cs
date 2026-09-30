var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(async (context, next) =>
{
    Console.WriteLine(context.Request.Path);
    await next();
});
app.MapGet("/health", () => Results.Ok("up"));
app.Run();
