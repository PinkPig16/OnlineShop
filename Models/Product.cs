using Azure.Core.Pipeline;
using OnlineShop.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal? Discount { get; set; }
        public decimal Stock { get; set; }
        public bool IsDeleted { get; set; } = false;
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        [ForeignKey("Testimonial")]
        public int TestimonialId { get; set; }
        public Testimonial? Testimonials { get; set;}

    }
}
