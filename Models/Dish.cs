#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models;

public class Dish
{
    [Key]
    public int DishId { get; set; }

    [Required(ErrorMessage = "Dish Name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Chef Name is required.")]
    public string Chef { get; set; }

    [Required(ErrorMessage = "Tastiness Level is required.")]
    [Range(1, 5, ErrorMessage = "Tastiness Level must be between 1 and 5.")]
    public int Tastiness { get; set; }

    [Required(ErrorMessage = "Calorie Amount is required.")]
    [Range(0, 2000, ErrorMessage = "Calories must be between 1 and 2000.")]
    public int Calories { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    [MaxLength(255, ErrorMessage = "Description must be 255 characters or less.")]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
