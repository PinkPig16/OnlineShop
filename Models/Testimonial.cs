using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        public string AuthorName { get; set; } = "Гость";
        public string? Description { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
