using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationApp.Models;

namespace ValidationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SystemUser systemUser)
        {
            if (ModelState.IsValid)
                return RedirectToAction("SystemUserInfo", systemUser);
            return View();
        }

        public IActionResult SystemUserInfo(SystemUser systemUser)
        {
            return View(systemUser);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
