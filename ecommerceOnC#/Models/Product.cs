using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Models
{
    public class Product // Represents a product in the e-commerce system
    {
        public int Id { get; set; }
        // Unique identifier for the product
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Descripción inválida")]
        public string Description { get; set; } = string.Empty;
    }
}