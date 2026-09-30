var result = validator.Validate(new CreateProductRequest("", 0));
foreach (var error in result.Errors) Console.WriteLine(error.PropertyName);
