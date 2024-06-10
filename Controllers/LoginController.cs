using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OnlineShop.Controllers
{
    [Route("/Login")]
    public class LoginController : Controller
    {
        [Route("/Login")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
