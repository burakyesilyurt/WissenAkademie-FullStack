using IdentityManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManagement.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<AppUser> userManager;
        private IPasswordHasher<AppUser> passwordHasher;
        public AdminController(UserManager<AppUser> _userManager, IPasswordHasher<AppUser> _passwordHasher)
        {
            userManager = _userManager;
            passwordHasher = _passwordHasher;
        }

        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            AppUser appUser = new AppUser()
            {
                UserName = user.Name,
                Email = user.Email,
            };
            IdentityResult result = await userManager.CreateAsync(appUser, user.Password);
            if (result.Succeeded)
                return RedirectToAction("Index", "Admin");
            else
            {
                foreach (IdentityError item in result.Errors)
                {
                    ModelState.AddModelError("Create_User_Error", $"{item.Code} - ${item.Description}");

                }
            }
            return View(user);
        }

        public async Task<IActionResult> Update(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
                return View(user);
            return RedirectToAction("Index", "Admin");

        }
        [HttpPost]
        public async Task<IActionResult> Update(string Id, string Email, string password)
        {
            AppUser user = await userManager.FindByIdAsync(Id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(Email))
                    user.Email = Email;
                else
                    ModelState.AddModelError("Update_User_Error", "Email cannot be empty");

                if (!string.IsNullOrEmpty(password))
                    user.PasswordHash = passwordHasher.HashPassword(user, password);
                else
                    ModelState.AddModelError("Update_User_PasswordHashError", "Password cannot be empty");
                if (!string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index", "Admin");

                    else
                        Errors(result);

                }
                else
                    ModelState.AddModelError("Update_User_Error", "User Not Found");
            }
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string Id)
        {
            AppUser user = await userManager.FindByIdAsync(Id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index", "Admin");
                else
                    Errors(result);
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View("Index", userManager.Users);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", $"{error.Code} - ${error.Description}");
            }
        }
    }
}
