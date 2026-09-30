var user = new ClaimsPrincipal(new ClaimsIdentity("Bearer"));
Console.WriteLine(user.Identity?.IsAuthenticated == true);
