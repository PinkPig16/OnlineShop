using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineShop.Data;
using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller


    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _productRepository.FindAll();
            return View(products);
        }
        public async Task<IActionResult> Details(Guid id)
        {
            Product product = await _productRepository.GetById(id);

            return View(product);
        }
    }
}
