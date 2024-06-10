using OnlineShop.Interfaces;

namespace OnlineShop.Service
{
    public class CookieKeysProvider : ICookieKeysProvider
    {
        public List<string> GetCookieKeys()
        {
           
            return new List<string> { "productCount", "productSum" };
        }
    }
}
