namespace EndustriApi.Entity;

public class Customer:BaseEntity
{
    public int CustomerId { get; set; }
    public required string Name { get; set; }
    public  string? Surname { get; set; }
    public string? District { get; set; }
    public string? City { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>();
    
   
}