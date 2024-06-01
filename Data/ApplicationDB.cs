using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Data
{
    public class ApplicationDB : DbContext
    {
        public DbSet<User> users { get; set; } = null!;
        public DbSet<Product> products { get; set; } = null!;
        public DbSet<Testimonial> testimonials { get; set; } = null!;
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
