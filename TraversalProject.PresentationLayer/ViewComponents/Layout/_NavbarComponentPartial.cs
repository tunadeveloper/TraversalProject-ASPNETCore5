using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.PresentationLayer.ViewComponents.Home
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
