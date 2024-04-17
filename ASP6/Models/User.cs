using System.ComponentModel.DataAnnotations;

namespace ASP6.Models;

public class User
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Enter name!!!")]
    public string Name { get; set; }

    [Required]
    [Range(1, 120, ErrorMessage = "Age between 16 and 100")]
    public int Age { get; set; }
}
