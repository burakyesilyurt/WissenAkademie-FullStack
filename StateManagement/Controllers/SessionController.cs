using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            //Add session on program.cs
            HttpContext.Session.SetString("AppName", "Contoso");
            HttpContext.Session.SetString("PersonName", "John Doe");
            HttpContext.Session.SetInt32("PersonAge", 30);
            HttpContext.Session.SetString("PersonMail", "john.doe@contoso.com");
            HttpContext.Session.SetString("Role", "User");
            return View();
        }

        public IActionResult ShowSession()
        {
            ViewBag.AppName = HttpContext.Session.GetString("AppName");
            ViewBag.PersonName = HttpContext.Session.GetString("PersonName");
            ViewBag.PersonAge = HttpContext.Session.GetInt32("PersonAge");
            ViewBag.PersonMail = HttpContext.Session.GetString("PersonMail");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            return View();
        }
    }
}
