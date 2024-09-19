using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Response.Cookies.Append("AppName", "Contoso");
            HttpContext.Response.Cookies.Append("PersonName", "John Doe");
            HttpContext.Response.Cookies.Append("PersonAge", "30");
            HttpContext.Response.Cookies.Append("PersonMail", "john.doe@contoso.com");
            HttpContext.Response.Cookies.Append("Role", "User");

            return View();
        }

        public IActionResult ShowCookie()
        {
            ViewBag.AppName = GetCookieVal("AppName");
            ViewBag.PersonName = GetCookieVal("PersonName");
            ViewBag.PersonAge = GetCookieVal("PersonAge");
            ViewBag.PersonMail = GetCookieVal("PersonMail");
            ViewBag.Role = GetCookieVal("Role");
            return View();
        }

        private string GetCookieVal(string key)
        {
            HttpContext.Request.Cookies.TryGetValue(key, out var val);
            return val;

        }
    }
}
