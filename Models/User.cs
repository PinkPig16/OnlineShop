using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    
    public class User : IdentityUser
    {
        public string? Addres { get; set; }

    }
}
