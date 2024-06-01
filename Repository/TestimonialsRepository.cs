using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Repository
{
    public class TestimonialsRepository : ITestimonialsRepository
    {
        public bool Add(Testimonial testimonial)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Testimonial user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Testimonial>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<Testimonial> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Testimonial user)
        {
            throw new NotImplementedException();
        }
    }
}
