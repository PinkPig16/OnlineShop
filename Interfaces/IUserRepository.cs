using OnlineShop.Models;

namespace OnlineShop.Interfaces
{
    interface  IUserRepository
    {
        Task<IEnumerable<User>> FindAll();
        Task<User> GetById(Guid id);
        bool Add(User user);
        bool Update(User user);
        bool Delete(User user);
        bool Save();
    }
}
