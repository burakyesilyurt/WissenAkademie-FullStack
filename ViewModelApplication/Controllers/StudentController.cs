using Microsoft.AspNetCore.Mvc;
using ViewModelApplication.Models;

namespace ViewModelApplication.Controllers
{
    public class StudentController : Controller
    {
        List<Gender> genders = new List<Gender>()
        {
            new Gender {ID=1,Name = "Erkek"},
            new Gender {ID=2,Name = "Kadın"},
        };
        List<Country> countrys = new List<Country>()
        {
            new Country {ID=1,Name="Türkiye"},
            new Country {ID=2,Name="USA"},
            new Country {ID=3,Name="UK"},

        };
        public IActionResult Index()
        {
            ViewData["Gender"] = genders;
            ViewData["Country"] = countrys;

            Student student = new Student();
            return View(student);
        }
    }
}
