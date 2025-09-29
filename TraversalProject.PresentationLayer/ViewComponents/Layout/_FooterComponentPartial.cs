using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.PresentationLayer.ViewComponents.Home
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
