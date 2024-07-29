using JQueryAJAX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JQueryAJAX.Controllers
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

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public CalculateNumbers Calculate(int num1, int num2)
        {
            CalculateNumbers calculateNumbers = new CalculateNumbers();
            calculateNumbers.Add = num1 + num2;
            calculateNumbers.Subtract = num1 - num2;
            calculateNumbers.Divide = num1 / num2;
            calculateNumbers.Multiply = num1 * num2;
            return calculateNumbers;
        }

        public IActionResult Personel()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Personel(Personel personel)
        {
            return Json(personel);

        }

        public IActionResult PersonelDetail(Personel personel)
        {
            return View(personel);
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
