var entity = new Product { Id = 7, Name = "Kettle", Price = 24.99m };
var response = entity.ToResponse();
Console.WriteLine($"{response.Id}: {response.Name}");
