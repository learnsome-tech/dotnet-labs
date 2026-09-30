using System.ComponentModel.DataAnnotations;

namespace Catalog.Application;

/// <summary>Bound from the "Catalog" configuration section.</summary>
public sealed class CatalogOptions
{
    public const string SectionName = "Catalog";

    [Required]
    [StringLength(3, MinimumLength = 3)]
    public string DefaultCurrency { get; set; } = "USD";

    [Range(1, 200)]
    public int DefaultPageSize { get; set; } = 20;

    [Range(1, 200)]
    public int MaxPageSize { get; set; } = 100;
