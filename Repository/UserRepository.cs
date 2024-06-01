using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool Add(User user)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
