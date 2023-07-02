using HealthyFoodWebApplication.Models;

namespace HealthyFoodWebApplication.Repositories.ShoppingBag
{
    public interface IShoppingBagRepository : IRepository<ShoppingBagItem>
    {
        void Save();
        public void Add(ShoppingBagItem entity);
      

    }
}
