using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.PresentationLayer.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
