var names = new[] { "Kettle", "Mug" }
    .Where(name => name.Length > 3)
    .Select(name => name.ToUpperInvariant());
foreach (var name in names) Console.WriteLine(name);
