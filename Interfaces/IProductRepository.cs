using OnlineShop.Models;

namespace OnlineShop.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> FindAll();
        Task<Product> GetById(Guid id);
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        bool Save();
    }
}
