using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OnlineShop.Interfaces;

namespace OnlineShop.Service
{
    public class CookieFIlter : IActionFilter
    {
        private readonly ICookieKeysProvider _cookieKeysProvider;
        public CookieFIlter(ICookieKeysProvider cookieKeysProvider)
        {
            _cookieKeysProvider = cookieKeysProvider;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var controller = context.Controller as Controller;
            if (controller != null)
            {
                var cookieKey = _cookieKeysProvider.GetCookieKeys();
                foreach (var key in cookieKey)
                {
                    if (context.HttpContext.Items.TryGetValue(key, out var value))
                    {
                        controller.ViewData[key] = value;
                    }
                }
            }            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
