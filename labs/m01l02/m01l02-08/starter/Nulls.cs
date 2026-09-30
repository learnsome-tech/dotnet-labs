string? sku = FindSku(7);

Console.WriteLine(Describe(sku));
Console.WriteLine(Describe(FindSku(1)));
Console.WriteLine(Length(sku));

static string? FindSku(int id) => id == 7 ? "WID-7" : null;

static string Describe(string? code) =>
    code is null ? "no sku" : $"sku is {code}";

static int Length(string? code) => code.Length;
