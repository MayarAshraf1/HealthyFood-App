using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HealthyFoodWebApplication.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        [DefaultValue(1)]
        public int Quantity { get; set; } = 0;

        public string Category { get; set; } = null!;
      
    }
}
