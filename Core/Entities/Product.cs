namespace Core.Entities;

public class Product : BaseEntity
{
    public string ProductName { get; set; } = string.Empty;
    public string ProductDescription { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? ImgUrl { get; set; }
    public ProductType? ProductType { get; set; }
    public int ProductTypeId { get; set; }
    public ProductBrind? ProductBrind { get; set; }
    public int ProductBrindId { get; set; }
}