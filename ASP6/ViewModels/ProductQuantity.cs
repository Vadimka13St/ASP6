namespace ASP6.ViewModels;

using System.ComponentModel.DataAnnotations;

public class ProductQuantity
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Enter number of products!!!!!")]
    public int Quantity { get; set; }
}