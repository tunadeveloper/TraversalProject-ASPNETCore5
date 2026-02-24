using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;

namespace TraversalProject.PresentationLayer.ViewComponents.MemberDashboard
{
    public class _GuideListComponentPartial : ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideListComponentPartial(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.GetListBL().Take(5).ToList();
            return View(values);
        }
    }
}
