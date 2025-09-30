using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.Models;

namespace TraversalProject.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel userRegisterViewModel)
        {
            AppUser appUser = new AppUser()
            {
                NameSurname = userRegisterViewModel.NameSurname,
                Email = userRegisterViewModel.Email,
                UserName = userRegisterViewModel.Email
            };
            var result = await _userManager.CreateAsync(appUser, userRegisterViewModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(userRegisterViewModel);
        }
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }
    }
}
