using Microsoft.AspNetCore.Mvc;
using PartialViewSample.Models;
using System.Diagnostics;

namespace PartialViewSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Product> products = new List<Product>()
        {
            new Product {ProductID = 1,ProductName="Name1",CategoryName="Category1",Description="Des1",Price = 10},
            new Product {ProductID = 2,ProductName="Name2",CategoryName="Category2",Description="Des2",Price = 20},
            new Product {ProductID = 3,ProductName="Name3",CategoryName="Category3",Description="Des3",Price = 15},
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(products);
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
