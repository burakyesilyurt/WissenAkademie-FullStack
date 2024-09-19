using Microsoft.AspNetCore.Mvc;
using StateManagement.Models;

namespace StateManagement.Controllers
{
    public class QueryStringController : Controller
    {
        public IActionResult Index(int idnum, string name, string password)
        {
            User user = new User()
            {
                Id = idnum,
                Name = name,
                Password = password
            };
            return View(user);
        }
    }
}
