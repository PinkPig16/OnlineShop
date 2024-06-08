using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OnlineShop.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
