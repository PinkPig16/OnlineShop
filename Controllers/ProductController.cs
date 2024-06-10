using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineShop.Data;
using OnlineShop.Interfaces;
using OnlineShop.Models;
using OnlineShop.ViewModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OnlineShop.Controllers
{
    [Route("/product")]
    public class ProductController : Controller


    {
        private Dictionary<string, Decimal> cookieData = new();
        private readonly IProductRepository _productRepository;
        private readonly ICookieKeysProvider _cookieKeysProvider;

        public ProductController(IProductRepository productRepository, ICookieKeysProvider cookieKeysProvider)
        {
            _productRepository = productRepository;
            _cookieKeysProvider = cookieKeysProvider;
        }

        [Route("/product")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var ViewModel = new ProductViewModel();

            IEnumerable<Product> products = await _productRepository.FindAll();
            ViewModel.Products = products;
            return View(products);
        }
        [HttpGet]
        [Route("/product/{NameUrl}")]
        public async Task<IActionResult> Details(string nameUrl, [FromQuery] Guid id)
        {
            Product product = await _productRepository.GetById(id);
            return View(product);
        }

        [HttpPost]
        [Route("/product/{NameUrl}")]
        public async Task<IActionResult> DetailsPost([FromForm] string nameUrl, [FromForm] Guid id)
        {
            Product product = await _productRepository.GetById(id);
            return View("Details", product);
        }
        [HttpPost]
        [Route("/product/AddProduct")]
        public IActionResult AddProduct()
        {
            var cookieKey = _cookieKeysProvider.GetCookieKeys();
            foreach (var key in cookieKey)
            {
                if (HttpContext.Request.Form.TryGetValue(key, out var valueForm))
                {
                    if (Decimal.TryParse(valueForm, out var valueInt))
                    {
                        cookieData.Add(key, valueInt);
                    }

                }
                if (HttpContext.Request.Cookies.TryGetValue(key, out var valueCookie))
                {
                    if (Decimal.TryParse(valueCookie, out var valueInt))
                        if (cookieData.ContainsKey(key))
                        {
                            cookieData[key] += valueInt;
                        }
                        else
                        {
                            cookieData.Add(key, valueInt);
                        }
                }
            }
            foreach (var item in cookieData)
            {
                HttpContext.Response.Cookies.Append(item.Key, item.Value.ToString());
            }
            return RedirectToAction("Index");
        }
    }
}
