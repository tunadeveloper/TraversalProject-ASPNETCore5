using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;

namespace TraversalProject.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IGuideService _guideService;

        public AboutController(IAboutService aboutService, IGuideService guideService)
        {
            _aboutService = aboutService;
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = new Models.GuideAndAboutListViewModel
            {
                Abouts = _aboutService.GetListBL(),
                Guides = _guideService.GetListBL()
            };
            return View(values);
        }
    }
}
