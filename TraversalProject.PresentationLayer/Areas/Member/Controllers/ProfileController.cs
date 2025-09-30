using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.PresentationLayer.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
