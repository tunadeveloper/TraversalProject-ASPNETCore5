using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            model.nameSurname = values.NameSurname;
            model.phoneNumber = values.PhoneNumber;
            model.email = values.Email;
            return View(model);
        }
    }
}
