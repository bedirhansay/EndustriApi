namespace EndustriApi.Entity;

public class Product:BaseEntity
{
    public int ProductId { get; set; }
    public required string ProductName { get; set; }
    public string? ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductStock { get; set; }
    public string? ProductImage { get; set; } 
    public int CategoryId { get; set; } 
    public virtual Category Category { get; set; } = null!;
    public List<Order> Orders { get; set; } = new List<Order>();
    
}