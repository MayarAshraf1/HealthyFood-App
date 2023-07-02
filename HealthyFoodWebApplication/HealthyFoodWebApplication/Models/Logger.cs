using System.ComponentModel.DataAnnotations;

namespace HealthyFoodWebApplication.Models
{
    public class Logger
    {
        public string FullName { get; set; } = null!;
        [Key]
        public string Username { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
        public string Role { get; set; } = null!;

        // Navigation Properties
        public ICollection<ShoppingBagItem> ShoppingBagItems { get; set; } = new List<ShoppingBagItem>();
    }
}
