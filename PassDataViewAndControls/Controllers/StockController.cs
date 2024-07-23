using Microsoft.AspNetCore.Mvc;

namespace PassDataViewAndControls.Controllers
{
    public class StockController : Controller
    {

        public IActionResult OrderInfo()
        {
            int ID = int.Parse(TempData["ID"].ToString());
            string Name = TempData["Name"].ToString();
            int Price = int.Parse(TempData["Price"].ToString());

            ViewBag.ID = ID;
            ViewBag.Name = Name;
            ViewBag.Price = Price;

            return View();
        }
    }
}
