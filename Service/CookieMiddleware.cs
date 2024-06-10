using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Service
{
    public class CookieMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ICookieKeysProvider _cookieKeysProvider;
        public CookieMiddleware(RequestDelegate next, ICookieKeysProvider cookieKeysProvider) 
        {
            _next = next;
            _cookieKeysProvider = cookieKeysProvider;
        }
        public async Task Invoke(HttpContext context)
        {
            var _cookieKey = _cookieKeysProvider.GetCookieKeys();
            foreach (var key in _cookieKey)
            {
                if (context.Request.Cookies.TryGetValue(key, out var value))
                {
                    context.Items[key] = value;
                }
            }

           await _next(context);
        }
    }
}
