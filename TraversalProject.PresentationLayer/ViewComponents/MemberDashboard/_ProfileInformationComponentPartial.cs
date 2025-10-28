using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.ViewComponents.MemberDashboard
{
    public class _ProfileInformationComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformationComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.NameSurname;
            ViewBag.phone = values.PhoneNumber;
            ViewBag.email = values.Email;
            return View();
        }
        }
}
