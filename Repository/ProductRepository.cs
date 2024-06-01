using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDB _context;
        public ProductRepository(ApplicationDB context)
        {
            _context = context;
        }
        public bool Add(Product product)
        {
           _context.products.Add(product);
            return Save();
        }

        public bool Delete(Product product)
        {
            _context.Remove(product);
            return Save();
        }

        public async Task<IEnumerable<Product>> FindAll()
        {
            return await _context.products.ToListAsync();
        }

        public async Task<Product> GetById(Guid id)
        {
            return await _context.products.FirstOrDefaultAsync(e => e.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
