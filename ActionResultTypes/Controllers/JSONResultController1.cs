using ActionResultTypes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
    public class JSONResultController1 : Controller
    {
        List<Employer> employees = new List<Employer>() {
            new Employer { ID = 1, Name = "John", Email = "example@mail.com",
                Address = new Address() { ID = 1, City = "NY", Country = "USA" }
            },
            new Employer { ID = 2, Name = "Jeyn", Email = "jeyn@mail.com",
                Address = new Address() { ID = 2, City = "London", Country = "UK" }
            }
        };
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetJsonEmployee()
        {
            return Json(employees);
        }
    }
}
