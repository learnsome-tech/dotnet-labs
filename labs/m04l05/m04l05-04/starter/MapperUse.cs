var mapper = new ProductMapper();
var response = mapper.ToResponse(product);
Console.WriteLine(response.Name);
