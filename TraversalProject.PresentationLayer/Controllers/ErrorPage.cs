using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.PresentationLayer.Controllers
{
    public class ErrorPage : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
