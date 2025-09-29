using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.PresentationLayer.ViewComponents.Layout
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
