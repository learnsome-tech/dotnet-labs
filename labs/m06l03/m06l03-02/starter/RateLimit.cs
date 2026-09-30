builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("catalog", limiter =>
    {
        limiter.PermitLimit = 100;
        limiter.Window = TimeSpan.FromMinutes(1);
    });
});
app.UseRateLimiter();
