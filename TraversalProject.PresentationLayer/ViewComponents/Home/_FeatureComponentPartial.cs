using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalProject.BusinessLayer.Abstract;

namespace TraversalProject.PresentationLayer.ViewComponents.Home
{
    public class _FeatureComponentPartial:ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _FeatureComponentPartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _featureService.GetListBL();
            ViewBag.PopularContentTitle = _featureService.GetListBL()
                               .FirstOrDefault(x => x.IsPopuler == true)?.Title;
            ViewBag.PopularContentImageUrl = _featureService.GetListBL()
                               .FirstOrDefault(x => x.IsPopuler == true)?.ImageUrl;
            @ViewBag.PopularContentDescription = _featureService.GetListBL()
                               .FirstOrDefault(x => x.IsPopuler == true)?.Description;
            return View(values);
        }
    }
}
