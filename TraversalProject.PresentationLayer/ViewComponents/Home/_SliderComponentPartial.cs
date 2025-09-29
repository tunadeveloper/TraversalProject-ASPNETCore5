using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.PresentationLayer.ViewComponents.Home
{
    public class _SliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
