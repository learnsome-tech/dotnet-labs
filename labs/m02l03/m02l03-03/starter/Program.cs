using var stream = File.OpenRead("missing.txt");
Console.WriteLine(stream.Length);
