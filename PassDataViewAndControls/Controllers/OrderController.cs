using Microsoft.AspNetCore.Mvc;

namespace PassDataViewAndControls.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult SellProduct(string ID, string Name, string Price)
        //{
        //    TempData["ID"] = int.Parse(ID);
        //    TempData["Name"] = Name;
        //    TempData["Price"] = int.Parse(Price);
        //    return RedirectToAction("OrderInfo", "Stock");
        //}

        [HttpPost]
        public IActionResult SellProduct(IFormCollection form)
        {
            TempData["ID"] = int.Parse(form["ID"].ToString());
            TempData["Name"] = form["Name"];
            TempData["Price"] = int.Parse(form["Price"].ToString());
            return RedirectToAction("OrderInfo", "Stock");
        }
    }
}
