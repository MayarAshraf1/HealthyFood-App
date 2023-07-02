using System.ComponentModel;

namespace HealthyFoodWebApplication.ViewModels
{
    public class ProductBagVM
    {
        public int  productId {get;set;}
        public string productName { get;set;}
        public float productPrice { get; set; }
        [DefaultValue(1)]
        public string productQuantity { get; set; } 
        public string productTotalPrice { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
