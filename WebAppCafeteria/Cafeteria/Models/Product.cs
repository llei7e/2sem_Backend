using System.ComponentModel.DataAnnotations;

namespace Cafeteria.Models;

public class Product {
    public int Id {get; set;} 
    public required string Name {get; set;} 
    public int Quantity {get; set;} 
    public required string Category {get; set;} 
    
    [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
    public decimal Price {get; set;} 
}