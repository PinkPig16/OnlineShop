using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{

    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
