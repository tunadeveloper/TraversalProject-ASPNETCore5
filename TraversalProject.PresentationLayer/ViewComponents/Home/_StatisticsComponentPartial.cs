using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.PresentationLayer.ViewComponents.Home
{
    public class _StatisticsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
