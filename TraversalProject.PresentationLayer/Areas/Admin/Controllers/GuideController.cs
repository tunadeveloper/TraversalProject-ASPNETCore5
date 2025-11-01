
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
