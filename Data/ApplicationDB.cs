using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;
using System.Reflection.Emit;

namespace OnlineShop.Data
{
    public class ApplicationDB : IdentityDbContext<User>
    {
        public DbSet<User> users { get; set; } = null!;
        public DbSet<Product> products { get; set; } = null!;
        public DbSet<Testimonial> testimonials { get; set; } = null!;
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
