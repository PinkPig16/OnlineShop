using OnlineShop.Data;
using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Service
{
    public class Service : IService
    {
        private readonly ApplicationDB _context;

        public Service(ApplicationDB context)
        {
            _context = context;

        }
        public void Print()
        {

        }
    }
}

