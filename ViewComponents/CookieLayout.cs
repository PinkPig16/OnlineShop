using Microsoft.AspNetCore.Mvc;
using OnlineShop.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace OnlineShop.ViewComponents
{
    public class CookieLayout : ViewComponent
    {
        private readonly ICookieKeysProvider _keysProvider;
        private Dictionary<string, string> cookieData;
        public CookieLayout(ICookieKeysProvider keysProvider)
        {
            _keysProvider = keysProvider;
        }
        public IViewComponentResult Invoke()
        {
            var CookieKey = _keysProvider.GetCookieKeys();
            foreach (var key in CookieKey) 
            {
                if (HttpContext.Items.TryGetValue(key, out var value) && value is string StringValue)
                {
                    cookieData.Add(key, StringValue);
                }
                cookieData.Add(key, "0");
            }
            return View(cookieData);
        }
    }
}
