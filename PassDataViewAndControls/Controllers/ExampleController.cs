using Microsoft.AspNetCore.Mvc;

namespace PassDataViewAndControls.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.GetDate = DateTime.Now.ToLongDateString();
            ViewBag.Names = new string[] { "John", "Jeyn", "Tom", "Hans" };

            ViewData["Hour"] = DateTime.Now.ToLongTimeString();

            TempData["Day"] = DateTime.Now.Day;
            return View();
            //Only the TempData can be sent
            // return RedirectToAction("Index2");
        }
        public IActionResult Index2()
        {

            return View();
        }
    }
}
