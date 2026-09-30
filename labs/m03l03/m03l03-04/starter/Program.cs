app.MapGet("/api/ping", () => Results.Ok("catalog"));
app.Run();
