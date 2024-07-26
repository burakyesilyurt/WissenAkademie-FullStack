using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
    public class FileResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public FileResult FileContent()
        {
            return File("~/Files/", "application/pdf");
        }
    }
}
