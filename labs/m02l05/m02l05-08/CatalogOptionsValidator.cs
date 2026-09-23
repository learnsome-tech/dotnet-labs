// Modern .NET Core, C# & Enterprise Microservices — lesson m02l05 — The Options Pattern: Strongly Typed Configuration
// https://learnsome.tech/courses/dotnet-course/watch?lesson=m02l05
// © LearnSome.tech
using Catalog.Application;
using Microsoft.Extensions.Options;

// One rule about two members: no single attribute can say this.
public sealed class CatalogOptionsValidator
    : IValidateOptions<CatalogOptions>
{
    public ValidateOptionsResult Validate(string? name, CatalogOptions o)
    {
        if (o.DefaultPageSize > o.MaxPageSize)
        {
            return ValidateOptionsResult.Fail(
                $"DefaultPageSize {o.DefaultPageSize} is above "
                + $"MaxPageSize {o.MaxPageSize}.");
        }

        return ValidateOptionsResult.Success;
    }
}

// services.AddSingleton<IValidateOptions<CatalogOptions>,
//     CatalogOptionsValidator>();
