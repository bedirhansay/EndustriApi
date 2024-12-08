using System.ComponentModel.DataAnnotations;

namespace EndustriApi.Entity;

public class Category : BaseEntity
{
    public int CategoryId { get; set; }

    [Required]
    [MaxLength(100),MinLength(3)]
    public required string CategoryName { get; set; }

    [MaxLength(500)]
    public string? CategoryDescription { get; set; }

    public bool CategoryStatus { get; set; } = true;

    public virtual List<Product> Products { get; set; } = new();
}