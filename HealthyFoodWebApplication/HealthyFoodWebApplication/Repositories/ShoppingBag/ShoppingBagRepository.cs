using HealthyFoodWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthyFoodWebApplication.Repositories.ShoppingBag
{
    public class ShoppingBagRepository : IShoppingBagRepository
    {
        HealthyFoodDbContext _context;
        public ShoppingBagRepository(DbContextOptions<HealthyFoodDbContext> options)
        {
            _context = new HealthyFoodDbContext(options);
        }
        public void Delete(int id)
        {
            ShoppingBagItem bagItem = GetById(id);
            _context.Remove(bagItem);


        }

        public List<ShoppingBagItem>? GetAll()
        {
            return _context.ShoppingBag.ToList();
        }

        public ShoppingBagItem? GetById(int id)
        {
            return _context.ShoppingBag.FirstOrDefault(x => x.Id == id);
        }


        public void Save()
        {
            _context.SaveChanges();
        }

        public void Add(ShoppingBagItem entity)
        {
            _context.ShoppingBag.Add(entity);
        }
        public void Insert(ShoppingBagItem entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ShoppingBagItem entity)
        {
            throw new NotImplementedException();
        }















    }
}
