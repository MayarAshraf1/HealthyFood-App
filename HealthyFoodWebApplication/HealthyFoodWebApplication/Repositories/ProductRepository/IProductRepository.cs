using HealthyFoodWebApplication.Models;

namespace HealthyFoodWebApplication.Repositories.ProductRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Save();
    }
}
