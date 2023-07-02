using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthyFoodWebApplication.Models
{
    public class ShoppingBagItem
    {
        [Key]
        public int Id { get; set; }
       
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; set; }

        public int ProductQuantity { get; set; } 
        public string? ProductTotalPrice { get; set; } = null!;

        [ForeignKey("Logger")]
        public string? Username { get; set; } = null!;

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

        // Navigation Properties
        public Logger Logger { get; set; } = null!;
     
    }
}
