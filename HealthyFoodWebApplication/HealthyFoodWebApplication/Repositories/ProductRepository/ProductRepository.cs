using HealthyFoodWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthyFoodWebApplication.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        HealthyFoodDbContext _context;
        public ProductRepository(DbContextOptions<HealthyFoodDbContext> options)
        {
            _context = new HealthyFoodDbContext(options);
        }
        public void Delete(int id)
        {
            Product product = GetById(id);
            _context.Product.Remove(product);
        }

        public List<Product>? GetAll()
        {
            return _context.Product.ToList();
        }

        public Product? GetById(int id)
        {
            return _context.Product.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Product entity)
        {
            _context.Product.Add(entity); 
        }

        public void Update(Product entity)
        {
            Product product = GetById(entity.Id);
            product.Name = entity.Name;
            product.Price = entity.Price;
            product.Category = entity.Category;
            _context.Product.Add(product);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
