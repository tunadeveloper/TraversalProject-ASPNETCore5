using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.Areas.Member.Models;

namespace TraversalProject.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.nameSurname = values.NameSurname;
            model.phoneNumber = values.PhoneNumber;
            model.email = values.Email;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
                return View(model);

            if (model.image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(model.image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = Path.Combine(resource, "wwwroot", "userImages", imageName);
                var directory = Path.GetDirectoryName(saveLocation);
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
                using (var stream = new FileStream(saveLocation, FileMode.Create))
                    await model.image.CopyToAsync(stream);
                user.ImageUrl = "/userImages/" + imageName;
            }

            user.NameSurname = model.nameSurname;
            user.Email = model.email ?? user.Email;
            user.PhoneNumber = model.phoneNumber ?? user.PhoneNumber;

            if (!string.IsNullOrWhiteSpace(model.password))
            {
                if (model.password != model.confirmPassword)
                {
                    ModelState.AddModelError(string.Empty, "Şifre ve şifre tekrar alanları eşleşmiyor.");
                    return View(model);
                }
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.password);
            }

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile", new { area = "Member" });
            }

            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, error.Description);
            return View(model);
        }
    }
}
