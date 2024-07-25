using Microsoft.AspNetCore.Mvc;
using PartialViewSample.Models;

namespace PartialViewSample.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product {ProductID = 1,ProductName="Name1",CategoryName="Category1",Description="Des1",Price = 10},
            new Product {ProductID = 2,ProductName="Name2",CategoryName="Category2",Description="Des2",Price = 20},
            new Product {ProductID = 3,ProductName="Name3",CategoryName="Category3",Description="Des3",Price = 15},
        };
        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            Product product = products.FirstOrDefault(product => product.ProductID == id);
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult ProductDetail(int id)
        {
            Product product = products.FirstOrDefault(product => product.ProductID == id);
            //return PartialView("ProductDetail", product);
            return PartialView("~/Views/Shared/ProductDetail.cshtml", product);
        }
    }
}
