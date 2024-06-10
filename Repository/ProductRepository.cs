using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDB _context;
        private readonly IService _service;
        public ProductRepository(ApplicationDB context, IService service)
        {
            _context = context;
            _service = service;
        }
        public bool Add(Product product)
        {
            product.NameUrl = _service.ToUrlFriendlyString(product.Name);
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

        public async Task<Product> GetByName(string name)
        {
            return await _context.products.FirstOrDefaultAsync(e => e.Name == name);
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
