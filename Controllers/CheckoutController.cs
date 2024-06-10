using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    [Route("/checkout")]
    public class CheckoutController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
