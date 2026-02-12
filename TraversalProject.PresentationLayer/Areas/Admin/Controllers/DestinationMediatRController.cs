using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationMediatRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
