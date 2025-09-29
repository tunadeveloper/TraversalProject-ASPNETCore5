using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DataAccessLayer.Abstract;

namespace TraversalProject.PresentationLayer.ViewComponents.Home
{
    public class _SubAboutComponentPartial:ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public _SubAboutComponentPartial(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _subAboutService.GetListBL().FirstOrDefault();
            return View(values);
        }
    }
}
