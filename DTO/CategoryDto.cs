namespace EndustriApi.DTO;

public class CategoryDto
{
    public required string CategoryName { get; set; }
    public string? CategoryDescription { get; set; }
    public  bool CategoryStatus { get; set; }
}

public class UpdateCategoryDto
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; } 
    public string? CategoryDescription { get; set; } 
    public bool? CategoryStatus { get; set; }
}