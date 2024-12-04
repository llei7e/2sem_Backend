using System.ComponentModel.DataAnnotations;

namespace CafeteriaAPI;

public class ProductDTO
{
    public string? Name { get; set; }
    public int Quantity { get; set; }
    public string? Category { get; set; }
    public decimal Price { get; set; }
}