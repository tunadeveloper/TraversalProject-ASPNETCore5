using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;

namespace TraversalProject.PresentationLayer.ViewComponents.Home
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        private readonly ITestimonalService _testimonalService;

        public _TestimonialComponentPartial(ITestimonalService testimonalService)
        {
            _testimonalService = testimonalService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonalService.GetListBL();
            return View(values);
        }
    }
}
