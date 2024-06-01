using OnlineShop.Models;

namespace OnlineShop.Interfaces
{
    public interface ITestimonialsRepository
    {
        Task<IEnumerable<Testimonial>> FindAll();
        Task<Testimonial> GetById(Guid id);
        bool Add(Testimonial testimonial);
        bool Update(Testimonial user);
        bool Delete(Testimonial user);
        bool Save();
    }
}
