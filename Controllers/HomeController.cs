using Microsoft.AspNetCore.Mvc;
using OnlineShop.Interfaces;
using OnlineShop.Service;

namespace OnlineShop.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly  IService _service;
        
        public HomeController(IService service) 
        {
            _service = service;
        }
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
